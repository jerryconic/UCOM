using System.Collections;
using System.ComponentModel.DataAnnotations;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Banker d1 = new();
Player p1 = new("John");
Player p2 = new("Nick");
Player p3 = new("Peter");
Player p4 = new("Tom");

d1.Shuffle();
p1.Clear();
p2.Clear();
p3.Clear();
p4.Clear();
for (int i = 0; i < 13; i++)
{
    d1.Deal(p1);
    d1.Deal(p2);
    d1.Deal(p3);
    d1.Deal(p4);
}
p1.ShowHand();
p2.ShowHand();
p3.ShowHand();
p4.ShowHand();
//Console.WriteLine("\u2660A \u2663K \u2665Q \u2666J");
/// <summary>
/// 樸克牌
/// </summary>
class Card : IComparable<Card>
{
    private string[] card_kind_string = ["\u2666", "\u2663", "\u2665", "\u2660"];
    //private readonly string[] card_kind_string = ["♠️", "♥️", "♣️", "♦️"];
    private string[] card_point_string = ["2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K", "A"];
    private string card_kind;
    private string card_point;
    private int index;
    /// <summary>
    /// 建構函式
    /// </summary>
    /// <param name="n">樸克牌的序號</param>
    public Card(int n)
    {
        index = n;
        card_kind = card_kind_string[n / 13].ToString();
        card_point = card_point_string[n % 13].ToString();
    }
    /// <summary>
    /// 花色(0:Spade, 1:Heart, 2:Club, 3:Diamond)
    /// </summary>
    public int Kind
    {
        get { return index / 13; }
    }
    public int CompareTo(Card? other)
    {

        return other == null ? 1 : index.CompareTo(other.index);
    }

    public override string ToString()
    {
        return card_kind + card_point;
    }
}
/// <summary>
/// 莊家
/// </summary>
class Banker
{
    private readonly Card[] card_stack = new Card[52];
    private int card_index = -1;

    public Banker()
    {
        for (int i = 0; i < 52; i++)
            card_stack[i] = new Card(i);
    }
    /// <summary>
    /// 洗牌
    /// </summary>
    public void Shuffle()
    {
        Random rnd = new();


        for (int i = 0; i < 52; i++)
        {
            int n = rnd.Next(0, 52);
            Card tmp;
            tmp = card_stack[i];
            card_stack[i] = card_stack[n];
            card_stack[n] = tmp;
        }
        card_index = -1;
    }
    /// <summary>
    /// 發牌
    /// </summary>
    /// <param name="p">發牌對象</param>
    public void Deal(Player p)
    {
        card_index++;
        p.GetCard(card_stack[card_index]);
    }
}
/// <summary>
/// 玩家
/// </summary>
class Player
{
    private List<Card> card_list = [];
    private string _name;
    public Player(string name)
    {
        _name = name;
    }
    /// <summary>
    /// 取牌
    /// </summary>
    /// <param name="c">樸克牌</param>
    public void GetCard(Card c)
    {
        card_list.Add(c);
    }
    /// <summary>
    /// 理牌, 將同樣花色排一起按AKQ...2順序排列
    /// </summary>
    public void SortCards()
    {
        card_list.Sort((a, b) => b.CompareTo(a));
    }
    /// <summary>
    /// 亮牌
    /// </summary>
    public void ShowHand()
    {
        SortCards();
        Console.Write($"{_name}:".PadLeft(10));
        foreach (Card c in card_list)
            Console.Write($"{c} ");
        Console.WriteLine();

    }
    /// <summary>
    /// 清牌
    /// </summary>
    public void Clear()
    {
        card_list.Clear();
    }
}