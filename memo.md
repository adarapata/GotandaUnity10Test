Unityでテスト何処から始めたらいいの？

まずPlayModeとEditMode

どっちがいいの？

個人的には全部PlayModeテストでいい気がする。


PlayMode!

Prefabをいい感じに呼び出す機能などはありません。

PlayerUnitの例

まずは、こいつにやってほしいことを思い出す。

- 移動する
- 弾を発射する
- 死亡する

### 移動する

移動する

ここからしんどい。なぜならば、Inputと移動処理が完全に結合しているため、Inputを弄らないとテストが書けない。
まずは、Inputと移動処理を切り離そう

