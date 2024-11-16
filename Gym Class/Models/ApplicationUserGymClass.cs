namespace Gym_Class.Models
{
    public class ApplicationUserGymClass
    {
        public int GymClassId { get; set; }
        //Must be string because Identity use GUID which is a string
        public string ApplicationUserId { get; set; }



    }
}
