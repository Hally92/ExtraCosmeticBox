# Changelog

## 1.0.6
- Fixed patch not applying when loaded alongside REPOLib or other mods
- Reverted PatchAll() to no-argument form to resolve BepInEx assembly resolution issue
- Added REPOLib soft dependency for correct load ordering
- REPOLibや他MODと同時導入時にパッチが適用されない問題を修正
- BepInExのアセンブリ解決問題に対応するためPatchAll()を引数なし形式に戻す
- ロード順序の安定化のためREPOLibをソフト依存関係に追加

## 1.0.5
- Refactored plugin structure and class organization
- Added safe Harmony unpatch handling on destroy
- Improved maintainability and patch initialization
- プラグイン構造とクラス構成を整理
- 終了時のHarmonyアンパッチ処理を追加
- パッチ初期化処理と保守性を改善

## 1.0.4
- Added MenuLib dependency
- Added REPOConfig dependency
- Improved Mod Manager automatic dependency installation
- MenuLib依存関係を追加
- REPOConfig依存関係を追加
- Mod Managerでの前提MOD自動導入に対応

## 1.0.3
- Fixed directory structure for better Mod Manager compatibility
- Updated package structure to flat layout
- Mod Managerとの互換性向上のためファイル構造を修正
- パッケージ構成をフラットレイアウトに更新

## 1.0.2
- Added Japanese README support
- Improved README formatting and explanations
- Improved installation instructions
- 日本語READMEを追加
- READMEの説明とフォーマットを改善
- 導入手順を改善

## 1.0.1
- Fixed dependency version
- Fixed mod manager install support
- 依存関係のバージョンを修正
- Mod Managerでのインストール対応を修正

## 1.0.0
- Initial release
- Added configurable cosmetic box extra roll attempts
- Added REPOConfig support
- Added multiplayer compatibility
- 初回リリース
- 衣装ボックスの追加抽選回数の設定機能を追加
- REPOConfigへの対応
- マルチプレイヤーに対応