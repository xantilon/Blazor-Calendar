using BlazorCalendar.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorCalendar;

partial class AnnualTask
{
    //private async Task ClickInternal(MouseEventArgs e, DateTime day)
    //{
    //    if(day == default) return;

    //    // There can be several tasks in one day :
    //    List<int> listID = new();
    //    if(TasksList != null)
    //    {
    //        for(var k = 0; k < TasksList.Length; k++)
    //        {
    //            Tasks t = TasksList[k];

    //            if(t.DateStart.Date <= day.Date && day.Date <= t.DateEnd.Date)
    //            {
    //                listID.Add(t.ID);
    //            }
    //        }
    //    }

    //    if(listID.Count > 0)
    //    {
    //        if(TaskClick.HasDelegate)
    //        {
    //            ClickTaskParameter clickTaskParameter = new()
    //            {
    //                IDList = listID,
    //                X = e.ClientX,
    //                Y = e.ClientY,
    //                Day = day
    //            };

    //            await TaskClick.InvokeAsync(clickTaskParameter);
    //        }
    //    }
    //    else
    //    {
    //        if(EmptyDayClick.HasDelegate)
    //        {

    //            ClickEmptyDayParameter clickEmptyDayParameter = new()
    //            {
    //                Day = day,
    //                X = e.ClientX,
    //                Y = e.ClientY
    //            };

    //            await EmptyDayClick.InvokeAsync(clickEmptyDayParameter);
    //        }
    //    }
    //}

    //private async Task HandleDragStart(DateTime day, int taskID)
    //{
    //    if(taskID < 0) return;

    //    TaskDragged = new Tasks()
    //    {
    //        ID = taskID
    //    };

    //    DragDropParameter dragDropParameter = new()
    //    {
    //        Day = day,
    //        taskID = TaskDragged.ID
    //    };

    //    await DragStart.InvokeAsync(dragDropParameter);
    //}

}
