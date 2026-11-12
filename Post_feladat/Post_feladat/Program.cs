namespace Post_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextPost textpost = new TextPost("A", "aaaaaaa");
            TextPost textpost2 = new TextPost("B", "bbbbbbbbbbbbbbbbbbbbbbbb");
            for(int i = 0; i < 3; i++)
            {
                textpost.Like();
            }
            Console.WriteLine(textpost.GetDescription());
            Console.WriteLine(textpost.Likes);
            Console.WriteLine(textpost2.GetDescription());
            Console.WriteLine(textpost2.Likes);
            ImagePost imagepost1 = new ImagePost("Rapó László", 3);
            ImagePost imagepost2 = new ImagePost("Péter Kármán", 2);
            
        }
    }
}
