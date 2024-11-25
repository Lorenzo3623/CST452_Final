namespace ButtonGrind.Models
{
    // Represents a button with its state and matching status
    public class ButtonModel
    {
        public int Id { get; set; }  // Unique ID of the button
        public int ButtonState { get; set; }  // Current state of the button 
        public bool matchFound { get; set; }  // Indicates if a match has been found

        // Constructor to create a button with an ID and initial state
        public ButtonModel(int id, int buttonState)
        {
            Id = id;  // Set the button's unique ID
            ButtonState = buttonState;  // Set the initial state of the button
        }
    }
}
