using Microsoft.AspNetCore.Components;

namespace BlazorCalendar;

public abstract class CalendarBase : ComponentBase
{
    /// <summary>
    /// User class names, separated by space. Applied on top of the component's own classes
    /// </summary>
    [Parameter]
    public string Class { get; set; }

    /// <summary>
    /// User styles, applied on top of the component's own styles.
    /// </summary>
    [Parameter]
    public string Style { get; set; }

    /// <summary>
    /// User styles of column headers, applied on top of the component's own  styles.
    /// </summary>
    [Parameter]
    public string HeaderStyle { get; set; }

    /// <summary>
    /// Allows the user to move the tasks
    /// </summary>
    [Parameter]
    public bool Draggable { get; set; } = false;

    /// <summary>
    /// Allows the user to change the background color of empty days
    /// </summary>
    [Parameter]
    public string WeekDaysColor { get; set; } = "#FFF";

    /// <summary>
    /// Allows the user to change the saturday background color
    /// </summary>
    [Parameter]
    public string SaturdayColor { get; set; } = "#bfbfbf";

    /// <summary>
    /// Allows the user to change the sunday background color
    /// </summary>
    [Parameter]
    public string SundayColor { get; set; } = "#a5a5a5";

    /// <summary>
    /// add a list of public holidays to display
    /// </summary>
    [Parameter]
    public Dictionary<DateOnly, string> PublicHolidays { get; set; } = new();

    /// <summary>
    /// public hooliday background color
    /// </summary>
    [Parameter]
    public string HolidayColor { get; set; } = "#e6af8f";
}
