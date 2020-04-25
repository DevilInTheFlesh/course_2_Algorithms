object FrmFind: TFrmFind
  Left = 0
  Top = 0
  Caption = #1055#1086#1080#1089#1082
  ClientHeight = 122
  ClientWidth = 232
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  OnHide = FormHide
  OnShow = FormShow
  PixelsPerInch = 96
  TextHeight = 13
  object LblNum: TLabel
    Left = 24
    Top = 16
    Width = 84
    Height = 13
    Caption = #1053#1086#1084#1077#1088' '#1090#1077#1083#1077#1092#1086#1085#1072
  end
  object BtnOK: TButton
    Left = 24
    Top = 80
    Width = 81
    Height = 25
    Caption = #1055#1088#1080#1085#1103#1090#1100
    ModalResult = 1
    TabOrder = 0
  end
  object BtnCncl: TButton
    Left = 120
    Top = 80
    Width = 81
    Height = 25
    Caption = #1054#1090#1084#1077#1085#1072
    ModalResult = 2
    TabOrder = 1
  end
  object Num: TEdit
    Left = 24
    Top = 35
    Width = 131
    Height = 22
    TabOrder = 2
  end
end
