namespace BlazorVendespilModel
{
    public class Card
    {
        public Card(int face)
        {
            State = State.Facedown;
            Face = face;
        }

        public State State { get; set; }
        public int Face { get; set; }
    }
}
