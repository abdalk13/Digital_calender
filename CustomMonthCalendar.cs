using System;
using System.Drawing;
using System.Windows.Forms;

namespace DigitalClockCalendar
{
    public class CustomMonthCalendar : MonthCalendar
    {
        private readonly DateTime[] _highlightDates;

        public CustomMonthCalendar(DateTime[] highlightDates)
        {
            _highlightDates = highlightDates;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            DrawHighlightedDates(e.Graphics);
        }

        private void DrawHighlightedDates(Graphics g)
        {
            foreach (DateTime date in _highlightDates)
            {
                Rectangle rect = GetDateRectangle(date);
                if (rect != Rectangle.Empty)
                {
                    // Draw a green rectangle behind the date
                    g.FillRectangle(Brushes.Green, rect);
                    g.DrawRectangle(Pens.Black, rect);

                    // Draw the date text on top of the green background
                    TextRenderer.DrawText(g, date.Day.ToString(), this.Font, rect, Color.White,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }
            }
        }

        private Rectangle GetDateRectangle(DateTime date)
        {
            // Calculate the rectangle position for the given date
            // This method needs to be adjusted based on your layout
            // The following is a rough approximation
            Rectangle dateRect = Rectangle.Empty;

            foreach (MonthCalendar.MonthCalendarMonth month in this.Controls.OfType<MonthCalendar.MonthCalendarMonth>())
            {
                foreach (MonthCalendar.MonthCalendarDay day in month.Controls.OfType<MonthCalendar.MonthCalendarDay>())
                {
                    if (day.Tag is DateTime dayDate && dayDate.Date == date.Date)
                    {
                        dateRect = day.Bounds;
                        break;
                    }
                }
            }

            return dateRect;
        }
    }
}
