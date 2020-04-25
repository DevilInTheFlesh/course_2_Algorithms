unit UFormEdit;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, Spin, UData, Grids;

type
  TFrmEdt = class(TForm)
    EdtFIO: TEdit;
    LblFIO: TLabel;
    LblAddr: TLabel;
    LblNum: TLabel;
    BtnOK: TButton;
    BtnCncl: TButton;
    Address: TEdit;
    Num: TEdit;
    procedure EdtFIOChange(Sender: TObject);
    procedure FormHide(Sender: TObject);
    procedure FormShow(Sender: TObject);
  private
    { Private declarations }
  public
    info : TInfo;
    FormState:TFormState;
    Grid:TStringGrid;
    Procedure Clear;
    Procedure ExportInfo;
    Procedure Import;
  end;

var
  FrmEdt: TFrmEdt;

implementation

{$R *.dfm}

procedure TFrmEdt.Clear;
begin
  EdtFIO.Text:='';
  Address.Text:='';
  Num.Text:='';
end;

procedure TFrmEdt.FormHide(Sender: TObject);
begin
  ExportInfo;
end;

procedure TFrmEdt.EdtFIOChange(Sender: TObject);
begin
  if EdtFIO.Text<>'' then
    BtnOK.Enabled:=true
  else
    BtnOK.Enabled:=false;
end;

procedure TFrmEdt.ExportInfo;
begin
  if ModalResult=mrOk then
    begin
      info.FIO:=EdtFIO.Text;
      info.Address:=Address.Text;
      info.Key:=Num.Text;
    end;
end;

procedure TFrmEdt.FormShow(Sender: TObject);
begin
  Import;
end;

procedure TFrmEdt.Import;
begin
  EdtFIO.Text:=info.FIO;
  Address.Text:=info.Address;
  Num.Text:=info.Key;
end;

end.
