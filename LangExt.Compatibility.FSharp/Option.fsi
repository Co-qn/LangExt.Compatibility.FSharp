﻿namespace LangExt.Compatibility.FSharp

open LangExt

/// LangExtのOptionに対する操作を提供するモジュールです。
module CsOption =
  /// LangExtのOptionを、F#のoptionに変換します。
  /// パイプライン演算子とともに使うことを想定しています。
  /// パイプライン演算子とともに使わない場合、ofCsOptionを使うとより自然に書けます。
  val toFsOption: Option<'a> -> 'a option

  /// F#のOptionを、LangExtのOptionに変換します。
  /// 関数適用の形で使うことを想定しています。
  /// 関数適用の形で使わず、パイプライン演算子とともに使う場合はtoCsOptionを使うとより自然に書けます。
  val ofFsOption: 'a option -> Option<'a>

/// F#のOptionとLangExtのOptionを相互変換するためのモジュールです。
module FsOption =
  /// F#のOptionを、LangExtのOptionに変換します。
  /// パイプライン演算子とともに使うことを想定しています。
  /// パイプライン演算子とともに使わない場合、ofFsOptionを使うとより自然に書けます。
  val toCsOption: 'a option -> Option<'a>

  /// LangExtのOptionを、F#のoptionに変換します。
  /// 関数適用の形で使うことを想定しています。
  /// 関数適用の形で使わず、パイプライン演算子とともに使う場合はtoFsOptionを使うとより自然に書けます。
  val ofCsOption: Option<'a> -> 'a option
