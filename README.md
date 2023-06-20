# Old_DungeonLegend

自作ゲーム「ダンジョンレジェンド」のソースコードです。

## 各ファイルの説明

### Player
![Player](https://github.com/Gu-ra/Old_DungeonLegend/assets/60833795/4d329fbc-617f-4abc-9d2c-f85e70166d2a)

### Player-HPCheck.cs
プレイヤーのHPを確認します。

### Player-HPText.cs
プレイヤーの現在HPを画面に表示します。

### Player-Player.cs
ダメージを受けると、プレイヤーのHPを減らすAddDamageメソッドを呼びます。

### Player-Respawn.cs
プレイヤーのHPが0になったとき、チェックポイントで復活します。


### Block
![Block](https://github.com/Gu-ra/Old_DungeonLegend/assets/60833795/c31e38d9-3edc-4e00-aff8-2fa90e1acb02)


爆弾で破壊出来るブロック

### RedBlock
<img width="100" alt="RedBlock" src="https://github.com/Gu-ra/Old_DungeonLegend/assets/60833795/8df2136e-1991-4a77-8067-3959ad1345e2">


RedBlockはスイッチをオンにしたときに出現し、オフにすると消えます。

### BlueBlock
<img width="100" alt="BlueBlock" src="https://github.com/Gu-ra/Old_DungeonLegend/assets/60833795/baa0eb05-5fd4-40e8-8a49-7fe72d78a4f7">


BlueBlockはスイッチをオフにしたときに出現し、オンにすると消えます。

### Switch
![Switch](https://github.com/Gu-ra/Old_DungeonLegend/assets/60833795/8e0e24b1-a8c1-4d02-8f54-e3a62d200bd5)
<img width="100" alt="SwitchOn" src="https://github.com/Gu-ra/Old_DungeonLegend/assets/60833795/cbc13242-00b4-4859-8526-1a9da8d77d25">

オンオフ切り替え出来るスイッチ。(左：オフ、右：オフ)

### Bomb
![Bomb](https://github.com/Gu-ra/Old_DungeonLegend/assets/60833795/86b04730-bd8e-45b4-92db-788de7202643)

プレイヤーがその場に生成する爆弾。爆発により、スイッチを起動したりブロックを壊せます。風で転がせます。
### Explosion
![Explosion](https://github.com/Gu-ra/Old_DungeonLegend/assets/60833795/73b0f517-2ffc-4b4e-9586-2cc820329558)

爆弾が爆発するとこのエフェクトが生成され、この範囲内に、爆風による当たり判定が出来ます。

### Knife
![Knife](https://github.com/Gu-ra/Old_DungeonLegend/assets/60833795/8c398752-89a6-4935-85e1-3402ca9faa00)

プレイヤーが投げるナイフ。ブロックは壊せないですが、遠くのスイッチを起動するのに使えます。

### Fire
![Fire](https://github.com/Gu-ra/Old_DungeonLegend/assets/60833795/975f8799-65a3-40f2-a2c6-568b70265b38)

当たるとプレイヤーにダメージが入ります。ソースコードはKnifeと同じなので、挙動は全く同じです。(テクスチャを変えただけです。)

### MovingFloor

<img width="183" alt="MovingFloor" src="https://github.com/Gu-ra/Old_DungeonLegend/assets/60833795/1ada0d8c-d489-4fb3-bafa-e623b130bf1f">

一定の区間を動く床です。

### Spike
<img width="245" alt="Spike" src="https://github.com/Gu-ra/Old_DungeonLegend/assets/60833795/7ffc0a60-6bca-43f0-b1d8-71337487d31f">

当たるとプレイヤーが即死するトラップです。

### Wind
<img width="206" alt="Wind" src="https://github.com/Gu-ra/DungeonLegend_Scripts/assets/60833795/5d4ec1db-f6ba-4865-8440-b75ab074c23b">

風で爆弾を転がせます。また、下から吹き上げる風に乗って、プレイヤーは浮くことが出来ます。
