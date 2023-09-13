namespace RouteMasterService.DTOs
{
    public class ExtraServiceProductInCalenderDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }

    public class ExtraServiceProductSelectCriteria
    {
        public int ExtraServiceId { get; set; }
        public int CurrentMonth { get; set; }
        public int CurrentYear { get; set; }
    }
}
