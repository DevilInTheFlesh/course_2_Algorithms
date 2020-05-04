unit MainForm;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Sort, Vcl.StdCtrls, Vcl.ExtCtrls;

type
  TForm1 = class(TForm)
    Image1: TImage;
    Edit1: TEdit;
    Button1: TButton;
    Button2: TButton;
    Button3: TButton;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
  mass : mas;
  ItemCount : integer;

implementation

{$R *.dfm}

procedure TForm1.Button1Click(Sender: TObject);
begin
  if Edit1.Text<>'' then
    begin
      inc(ItemCount);
      mass[ItemCount].key:= StrToInt(Edit1.Text);
      Edit1.Text:='';
      printMas(mass,1,ItemCount,Image1);
    end
  else
    ShowMessage('������� ��������');
end;

procedure TForm1.Button2Click(Sender: TObject);
begin
  Image1.Picture:=nil;
  ItemCount:=0;
end;

procedure TForm1.Button3Click(Sender: TObject);
begin
  SortMas(mass,1,ItemCount,Image1);
end;

Initialization
  ItemCount:=0;

end.
