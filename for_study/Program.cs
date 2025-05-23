//冒険プログラムのステータスの話

float attackPower = 10; //攻撃力10

Console.WriteLine("現在の攻撃力：" + attackPower);

//インクリメント演算子
attackPower++; //1増やす
//++attackPower; //これもあり

Console.WriteLine("インクリメント後の攻撃力：" + attackPower);

//デクリメント演算子
attackPower--; //1減らす
//--attackPower; //これもあり

Console.WriteLine("デクリメント後の攻撃力：" + attackPower);

//攻撃の係数
float[] attack_k = { 1, 1.2f, 1.2f, 2.5f, 1 };

Random rand = new Random();
int result;

for (int i = 0; i < attack_k.Length; i++)
{
    result = rand.Next(0, 5);
    Console.WriteLine("プレイヤーの攻撃：" + attackPower * attack_k[result]);
}

//おみくじの結果
string[] omikuji = { "大吉", "吉", "末吉", "凶" };

//result = rand.Next(0, 4);
//Console.WriteLine("おみくじの結果：" + omikuji[result]);

//while (result != 0)
//{
//    result = rand.Next(0, 4);
//    Console.WriteLine("おみくじの結果：" + omikuji[result]);
//}

//do
//{
//    result = rand.Next(0, 4);
//    Console.WriteLine("おみくじの結果：" + omikuji[result]);
//} while (result != 0);


//result = 1;
//while (result != 0)
//{
//    result = rand.Next(0, 4);
//    Console.WriteLine("おみくじの結果：" + omikuji[result]);
//}

//Console.WriteLine("今年はついてるなあ！");

//for (int i = 0; i < omikuji.Length; i++)
//{
//    Console.WriteLine("おみくじの結果：" + omikuji[i]);
//}

foreach(string omi in omikuji)
{
    Console.WriteLine("おみくじの結果：" + omi);
}
