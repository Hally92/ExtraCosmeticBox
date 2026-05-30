# Extra Cosmetic Box

衣装ボックス(Cosmetic Box)の抽選回数を加算します。
Adds configurable extra cosmetic box roll attempts for cosmetic boxes.

---

## How It Works / 動作概要

This mod does NOT directly increase cosmetic box spawn chance.
Instead, it adds extra cosmetic roll attempts while preserving the game's original spawn rates and rarity balance.

このMODは衣装ボックスの「出現確率そのもの」は変更しません。

代わりに、ゲーム内部で行われている抽選回数を加算することで、
自然なバランスを維持したままボックスの出現数を増やします。

### Examples / 設定例

* 0 = Vanilla / バニラ(MOD無し)と同じ
* 2 = Slightly more frequent / 少し出やすい
* 10 = Cosmetic box apocalypse / バランス崩壊注意

---

## Features

* Configurable extra cosmetic roll attempts
* REPOConfig compatible
* Multiplayer friendly
* Keeps vanilla rarity balance intact

### 本MODの機能

* 衣装ボックス抽選回数を設定可能
* REPOConfig対応
* マルチプレイ対応
* バニラのレアリティバランスを維持

---

## Configuration / 設定

This mod supports in-game configuration through REPOConfig.
このMODは REPOConfig によるゲーム内設定に対応しています。

|Setting / 設定項目|Default / 初期値|Range / 範囲|
|-|:-:|:-:|
|Additional Cosmetic Rolls|2|0 - 10|

---

## Multiplayer / マルチプレイ

**All players are recommended to install this mod.**
If a guest does not have the mod installed, cosmetic box counting may be unstable on their end.
The number of cosmetic boxes that spawn is determined by the host's setting.

**全員の導入を推奨します。**
ゲスト側がMODを導入していない場合、コスメボックスの納品カウントが正常に行われない可能性があります。
コスメボックスのスポーン数はホスト側の設定値によって決まります。

---

## Installation / 導入方法

### r2modman / Thunderstore Mod Manager

Install directly using r2modman or Thunderstore Mod Manager.
r2modman または Thunderstore Mod Manager から直接インストールしてください。

---

### Manual Installation / 手動導入

Extract the downloaded ZIP file and place the `HalHally-ExtraCosmeticBox` folder into:
ダウンロードしたZIPを展開し、`HalHally-ExtraCosmeticBox` フォルダを以下へ配置してください。

```txt
r2modmanPlus-local\REPO\profiles\Default\BepInEx\plugins
```

---

## Dependencies / 前提MOD

The following dependencies will be installed automatically when using Mod Manager.
以下の前提MODは Mod Manager 使用時に自動導入されます。

- BepInExPack
- MenuLib
- REPOConfig

---

## Source

Created by HalHally.

