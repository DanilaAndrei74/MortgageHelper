
namespace BusinessLogic.Services
{
    public class DueDateIterator
    {
        private List<DateOnly> dates = new List<DateOnly>();
        private int currentIndex = 0;

        // Add a date to the list
        public void AddDate(DateOnly date)
        {
            dates.Add(date);
        }

        // Get the next date in the sequence
        public DateOnly? Next()
        {
            if (dates.Count == 0) return new DateOnly(); // No dates available

            DateOnly nextDate = dates[currentIndex];
            currentIndex = (currentIndex + 1) % dates.Count; // Move to the next, loop around

            return nextDate;
        }

        // Reset to the start
        public void Reset()
        {
            currentIndex = 0;
        }

        public void HardReset()
        {
            dates = new List<DateOnly>();
        }
    }
}
