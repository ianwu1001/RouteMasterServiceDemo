using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RouteMasterService.DTOs;
using RouteMasterService.Models;

namespace RouteMasterService.Controllers
{
    [EnableCors("AllowAny")]
    [Route("api/[controller]")]
    [ApiController]
    public class TravelPlansController : ControllerBase
    {
        private readonly RouteMasterContext _context;

        public TravelPlansController(RouteMasterContext context)
        {
            _context = context;
            
        }



        [HttpGet]
        [Route("Get/AllAttractionsInfo")]
        public async Task<IEnumerable<SelectAttractionAllInfoDto>> GetAllAttractionsInfo()
        {
            var data = _context.Attractions.Select(x => new SelectAttractionAllInfoDto
            {
                AttractionId = x.Id,
                AttractionName = x.Name,
                StayHours = (int)Math.Round(_context.CommentsAttractions.Where(c => c.AttractionId == x.Id && c.StayHours != null).Select(c => c.StayHours.Value).Average()),
                PositionX = x.PositionX,
                PositionY = x.PositionY,

                ExtListInAtt = x.ExtraServices.Select(e => new ExtInAtt
                {
                    ExtId = e.Id,
                    ExtName = e.Name,
                }).ToList(),

                ActListInAtt = x.Activities.Select(ac => new ActInAtt
                {
                    ActId = ac.Id,
                    ActName = ac.Name,
                }).ToList(),
            });


            return data;


        }



        [HttpGet]
        [Route("Get/VuePageExtProductsInfo")]
        public async Task<IEnumerable<ExtraServiceProductTravelCreateVuePageDto>> GetExtVuePageProductsInfo(int extraServiceId, DateTime beginDateTime)
        {
            var extProductsInDb = _context.ExtraServiceProducts
                .Include(x => x.ExtraService)
                .Where(x => x.ExtraServiceId == extraServiceId)
                .Where(x => x.Date == beginDateTime.Date).Select(x => new ExtraServiceProductTravelCreateVuePageDto
                {
                    ExtraServiceProductId = x.Id,
                    ExtraServiceName = x.ExtraService.Name,
                    Quantity = x.Quantity,
                    Price = x.Price,

                });
            return extProductsInDb;


        }






        [HttpGet]
        [Route("Get/VuePageActProductsInfo")]
        public async Task<IEnumerable<ActivityProductTravelCreateVuePageDto>> GetActVuePageProductsInfo(int activityId, DateTime beginDateTime)
        {
            var actProductsInDb = _context.ActivityProducts
                .Include(x => x.Activity)
                .Where(x => x.ActivityId == activityId)
                .Where(x => x.Date == beginDateTime.Date).Select(x => new ActivityProductTravelCreateVuePageDto
                {
                    ActivityProductId = x.Id,
                    ActivityName = x.Activity.Name,
                    Quantity = x.Quantity,
                    Price = x.Price,
                    StartTime = beginDateTime.Date.Add(x.StartTime),
                    EndTime = beginDateTime.Date.Add(x.EndTime)
                });
            return actProductsInDb;


        }




        [HttpGet]
        [Route("Get/CalculateTransportTime/DurationValue")]
        public async Task<ActionResult<DateTime>> GetStartTimeByDurationValue(DateTime prevEndTime, int durationSeconds)
        {


            int minuteValue = durationSeconds / 60;
            var result = prevEndTime.AddMinutes(minuteValue);


            return result;

        }





        [HttpGet]
        [Route("Get/CalculateTransportTime/StayHours")]
        public async Task<ActionResult<DateTime>> GetEndTimeByStayHours(DateTime startTime, int stayHours)
        {
            var result = startTime.AddHours(stayHours);


            return result;

        }




        [HttpPost]
        [Route("Post/SaveVuePageSchduleData")]

        public async void SaveVuePageSchduleData(VuePageSchduleItemListDto dto)
        {
            //清空原有資料



            if (dto.VuePageSchduleObjs != null)
            {
                for (int i = 0; i < dto.VuePageSchduleObjs.Length; i++)
                {
                    var newSchedule = new Schedule();
                    newSchedule.MemberId = dto.memberId;
                    newSchedule.CreateDate = dto.createDate;
                    newSchedule.Content = dto.VuePageSchduleObjs[i].title;



                    if (!string.IsNullOrEmpty(dto.VuePageSchduleObjs[i].start))
                    {
                        newSchedule.StartTime = DateTime.Parse(dto.VuePageSchduleObjs[i].start);
                    }
                    else
                    {
                        newSchedule.StartTime = null;
                    }


                    if (!string.IsNullOrEmpty(dto.VuePageSchduleObjs[i].end))
                    {
                        newSchedule.EndTime = DateTime.Parse(dto.VuePageSchduleObjs[i].end);
                    }
                    else
                    {
                        newSchedule.StartTime = null;
                    }

                    _context.Schedules.Add(newSchedule);
                    _context.SaveChanges();

                }

            }
        }







        [HttpGet("Get/SchduleData")]
        public async Task<IEnumerable<SchduleFromDbDto>> GetSchduleData(int memberId)
        {

            var data = _context.Schedules.Where(x => x.MemberId == memberId).Select(x => new SchduleFromDbDto
            {
                Title = x.Content,
                Start = x.StartTime,
                End = x.EndTime
            });


            return data;
        }





    }
}
