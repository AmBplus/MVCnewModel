namespace MVCnewModel.Models
{
    public interface ICostRepository
    {
        public abstract Cost GetCostByID(int id);
    }
}
