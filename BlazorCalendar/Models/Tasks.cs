namespace BlazorCalendar.Models;

using System.Diagnostics;

[DebuggerDisplay("{ID} {Code} {DateStart}")]
public sealed class Tasks
{
    public int ID { get; set; }
    public string? Key { get; set; }
    public string Caption { get; set; }
    public string Code { get; set; }
    public string Color { get; set; }
    public string? ForeColor { get; set; } = null;
    public FillStyleEnum FillStyle { get; set; }
    public string? Comment { get; set; } = null;
    public DateTime DateStart { get; set; }
    public DateTime DateEnd { get; set; }
    public bool NotBeDraggable { get; set; }
	public int Type { get; set; }

    public string GetTaskContent(PriorityLabel priorityLabel)
    {
        if(priorityLabel == PriorityLabel.Code)
        {
            return string.IsNullOrWhiteSpace(Code) ? Caption : Code;
        }
        else
        {
            return string.IsNullOrWhiteSpace(Caption) ? Code : Caption;
        }
    }

    public bool IncludesDay(DateTime day) => DateStart <= day && DateEnd >= day;
    public bool IsFirstDay(DateTime day) => DateStart.Date == day.Date;
    public bool IsLastDay(DateTime day) => DateEnd.Date == day.Date;
    public bool IsSingleDay => DateStart.Date == DateEnd.Date;
    public int Duration => (DateEnd-DateStart).Days;

    public override string ToString()
    {
        //return $"Caption: {Caption}, Code: {Code}, Color: {Color}, ForeColor: {ForeColor}, FillStyle: {FillStyle}, Comment: {Comment}, DateStart: {DateStart}, DateEnd: {DateEnd}, Type: {Type}";
        return $"Key: {Key}, Caption: {Caption}, Code: {Code}, Comment: {Comment}, Type: {Type}";
    }

	// Split a task into multiple tasks if it spans multiple months
	public IEnumerable<Tasks> SplitMonths()
	{
		var monthDifference = ((DateEnd.Year - DateStart.Year) * 12) + DateEnd.Month - DateStart.Month;

		for(var i = 0; i <= monthDifference; i++)
		{
			var start = DateStart.AddMonths(i);
			if(i != 0)
			{
				start = new DateTime(start.Year, start.Month, 1);
			}

			var end = new DateTime(start.Year, start.Month, DateTime.DaysInMonth(start.Year, start.Month));
			if(i == monthDifference)
			{
				end = DateEnd;
			}

            yield return new Tasks 
            {
                ID = ID,
                Key = Key,
                Caption = Caption,
                Code = Code,
                Color = Color,
                ForeColor = ForeColor,
                FillStyle = FillStyle,
                Comment = Comment,
                DateStart = start,
                DateEnd = end,
                NotBeDraggable = NotBeDraggable,
                Type = Type
            };
		}
	}
	
    
}
