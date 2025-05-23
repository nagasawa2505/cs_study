const float maxHP = 10; //プレイヤーの最大HP //定数
float currentHP = maxHP; //その時々のHP
currentHP = 3;

int result; //何を踏んだかの結果
Random rand = new Random(); //ランダムな機能を持っているRandomクラスの能力を変数randに実体化(randという名前で実体化)
result = rand.Next(0, 4); //Nextメソッドがランダム値を出す(0以上4未満(つまり3まで))

int cure = 5;
int poison = 5;

Console.WriteLine("最初のHP：" + currentHP);

switch (result)
{
    case 1:
        Console.WriteLine("回復した");
        break;
    case 2:
        Console.WriteLine("毒をふんだ");
        break;
    case 3:
        Console.WriteLine("罠にかかった");
        break;
    default:
        Console.WriteLine("何もおきなかった");
        break;
}
