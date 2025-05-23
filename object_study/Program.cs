//複数のプレイヤーをたくさん登場させて、
//それぞれのステータスを除いたり、
//特技を順番に披露させるプログラム

using object_study;

Player suzuki = new Player();
suzuki.Name("鈴木");
suzuki.Attack();
suzuki.StatusDisplay();

Player tanaka = new Player();
tanaka.Name("田中");
tanaka.Attack();
tanaka.StatusDisplay();

Player yamada = new Player();
yamada.Name("山田");
yamada.Attack();
yamada.StatusDisplay();
