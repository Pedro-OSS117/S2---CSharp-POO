namespace Exo2
{
    public class Roman : Livre
    {
        public enum Reward
        {
            Goncourt,
            Medicis,
            Interallie
        }
        
        private Reward _reward;
        
        public Roman(int registerNumber, string title, string author, int numberPages, Reward reward) : base(registerNumber, title, author, numberPages)
        {
            _reward = reward;
        }

        public override string ToString()
        {
            return  base.ToString() + $", Reward : {_reward}";
        }
    }
}