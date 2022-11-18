namespace lecture9
{
    internal class Company
    {
        public bool isLocal { get; set; }
        public int isLocalcheck()
        {
            if (isLocal)
            {
                return 18;
            }
            else
            {
                return 5;
            }
        }
    }
}
