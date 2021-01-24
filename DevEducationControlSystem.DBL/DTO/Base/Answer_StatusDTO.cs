namespace DevEducationControlSystem.DBL.DTO.Base
{
    public class Answer_StatusDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Answer_StatusDTO()
        {

        }
        public Answer_StatusDTO(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}