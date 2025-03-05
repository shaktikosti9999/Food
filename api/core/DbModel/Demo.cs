namespace core.DbModel
{
    public class Demo
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public int RowId { get; set; }
        public string? DemoText { get; set; }

    }
}
