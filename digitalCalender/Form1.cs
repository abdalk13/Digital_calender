using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigitalCalendar
{
    public partial class Form1 : Form
    {
        private Dictionary<DateTime, List<string>> eventsByDate;

        public Form1()
        {
            InitializeComponent();
            eventsByDate = new Dictionary<DateTime, List<string>>();
            monthCalendar.DateSelected += monthCalendar_DateSelected;
            UpdateEventList();
            HighlightDatesWithEvents();
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = monthCalendar.SelectionRange.Start;
            string eventText = txtEvent.Text;

            if (!string.IsNullOrWhiteSpace(eventText))
            {
                if (!eventsByDate.ContainsKey(selectedDate))
                {
                    eventsByDate[selectedDate] = new List<string>();
                }
                eventsByDate[selectedDate].Add(eventText);
                txtEvent.Clear();
                UpdateEventList();
                HighlightDatesWithEvents();
            }
            else
            {
                MessageBox.Show("Please enter an event.");
            }
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            if (lstEvents.SelectedItem != null)
            {
                DateTime selectedDate = monthCalendar.SelectionRange.Start;
                string selectedEvent = lstEvents.SelectedItem.ToString();

                if (eventsByDate.ContainsKey(selectedDate))
                {
                    eventsByDate[selectedDate].Remove(selectedEvent);
                    UpdateEventList();
                    HighlightDatesWithEvents();
                }
            }
            else
            {
                MessageBox.Show("Please select an event to delete.");
            }
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            UpdateEventList();
        }

        private void UpdateEventList()
        {
            lstEvents.Items.Clear();
            DateTime selectedDate = monthCalendar.SelectionRange.Start;

            if (eventsByDate.ContainsKey(selectedDate))
            {
                foreach (var ev in eventsByDate[selectedDate])
                {
                    lstEvents.Items.Add(ev);
                }
            }
        }

        private void HighlightDatesWithEvents()
        {
            monthCalendar.RemoveAllBoldedDates();
            foreach (DateTime date in eventsByDate.Keys)
            {
                monthCalendar.AddBoldedDate(date);
            }
            monthCalendar.UpdateBoldedDates();
        }
    }
}
