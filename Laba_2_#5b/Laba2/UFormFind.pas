unit UFormFind;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, Spin,UData;

type
  TFrmFind = class(TForm)
    LblNum: TLabel;
    BtnOK: TButton;
    BtnCncl: TButton;
    Num: TEdit;
    procedure FormShow(Sender: TObject);
    procedure FormHide(Sender: TObject);
  private
    { Private declarations }
  public
    Key:TKey;
  end;

var
  FrmFind: TFrmFind;

implementation

{$R *.dfm}

procedure TFrmFind.FormHide(Sender: TObject);
begin
  Key:=Num.Text;
end;

procedure TFrmFind.FormShow(Sender: TObject);
begin
  Num.Text:='';
end;

end.
