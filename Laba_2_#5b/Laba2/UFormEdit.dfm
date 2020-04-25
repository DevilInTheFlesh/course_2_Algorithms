object FrmEdt: TFrmEdt
  Left = 0
  Top = 0
  Caption = #1056#1077#1076#1072#1082#1090#1080#1088#1086#1074#1072#1085#1080#1077'/'#1044#1086#1073#1072#1074#1083#1077#1085#1080#1077
  ClientHeight = 197
  ClientWidth = 385
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
  object LblFIO: TLabel
    Left = 16
    Top = 16
    Width = 39
    Height = 16
    Caption = #1060'.'#1048'.'#1054'.'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -13
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object LblAddr: TLabel
    Left = 16
    Top = 74
    Width = 35
    Height = 16
    Caption = #1040#1076#1088#1077#1089
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -13
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object LblNum: TLabel
    Left = 176
    Top = 74
    Width = 99
    Height = 16
    Caption = #1053#1086#1084#1077#1088' '#1090#1077#1083#1077#1092#1086#1085#1072
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -13
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object EdtFIO: TEdit
    Left = 22
    Top = 38
    Width = 329
    Height = 21
    TabOrder = 0
    OnChange = EdtFIOChange
  end
  object BtnOK: TButton
    Left = 80
    Top = 148
    Width = 97
    Height = 29
    Caption = 'OK'
    Enabled = False
    ModalResult = 1
    TabOrder = 1
  end
  object BtnCncl: TButton
    Left = 208
    Top = 148
    Width = 97
    Height = 30
    Caption = 'Cancel'
    ModalResult = 2
    TabOrder = 2
  end
  object Address: TEdit
    Left = 22
    Top = 96
    Width = 131
    Height = 22
    TabOrder = 3
  end
  object Num: TEdit
    Left = 182
    Top = 96
    Width = 131
    Height = 22
    TabOrder = 4
  end
end
