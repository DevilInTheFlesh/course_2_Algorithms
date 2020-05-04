unit Sort;

interface

  uses Winapi.Windows, System.SysUtils, Vcl.Graphics, Vcl.Forms, Vcl.ExtCtrls;

  type

    rec = record
      key : integer;
    end;

    mas = array [1..100] of rec;

    procedure Sliv(var a:mas;p,q : integer;Image1: TImage);
    procedure SortMas(var a:mas;p,q : integer;Image1:TImage);
    procedure printMas(X: mas; start,n: integer; Image1: TImage; top : integer = 0);
    procedure printWhite(X: mas; n: integer; Image1: TImage; top : integer = 0);

implementation

  procedure Sliv(var a:mas;p,q : integer;Image1: TImage); //��������� ��������� �������, p-������, q-�����
  var r,i,j,k : integer;
      b:mas;
  begin
    for i := 1 to q do
      b[i]:=a[i];
    r:=(p+q) div 2;{����� ������}
    i:=p;{������ ����� ��������}
    j:=r+1;{������ ������ ��������}
    printMas(a,i,r,Image1,100);
    printMas(a,r+1,q,Image1,200);
    Sleep(1000);
    Application.ProcessMessages;
    for k:=p to q do{������� �� ������ �� �����}
    if (i<=r) and ((j>q) or (a[i].key<a[j].key)) then {������������ �������� �� ������� � ����� ������, ������������ ����}
      begin
       b[k]:=a[i];
       i:=i+1;
        printMas(b,1,q,Image1);
        Sleep(1000);
        Application.ProcessMessages;
      end
    else
      begin
       b[k]:=a[j];
       j:=j+1;
        printMas(b,1,q,Image1);
        Sleep(1000);
        Application.ProcessMessages;
      end ;
    for k:=p to q do
      a[k]:=b[k];
    printMas(a,1,q,Image1);
    printWhite(a,q,Image1,100);
    printWhite(a,q,Image1,200);
    Sleep(1000);
    Application.ProcessMessages;
  end;

  {����������� ��������� ����������, ��������� ���� ��������
  ������ ������ ��������, ��������� ������� � ����� ��� ������ ������ �������}
  procedure SortMas(var a:mas;p,q : integer; Image1:TImage); //p,q - ������� ������ � ����� ����������� ����� �������
  begin
    if p<q then {������ �� ������ �������� ���������� ����������}
    begin
      SortMas(a,p,(p+q) div 2,Image1);
      SortMas(a,(p+q) div 2 + 1,q,Image1);
      Sliv(a,p,q,Image1);

    end;

  end;

  procedure printMas(X: mas; start,n: integer; Image1: TImage; top : integer = 0);
  var i,block, ShapeLeft, ShapeTop: Integer;
  begin
    ShapeLeft := 0;
    ShapeTop := 4 + top;
    block:=10;
    for i:=start to n do
    begin
      Image1.Canvas.Pen.Width := 4;
      Image1.Canvas.Pen.Color := clBtnText;
      Image1.Canvas.Brush.Color := clWhite;
      ShapeLeft := ShapeLeft+50;
      Image1.Canvas.Rectangle(ShapeLeft, ShapeTop, ShapeLeft+50, ShapeTop+50);
      Image1.Canvas.Font.Size := 7;
      Image1.Canvas.TextOut ( ShapeLeft+17, ShapeTop+20,' '+IntToStr(x[i].key));
      if i=block then
      begin
        ShapeTop:=ShapeTop+50;
        ShapeLeft:=0;
        block:=block+10;
      end;
    end;
  end;

  procedure printWhite(X: mas; n: integer; Image1: TImage; top : integer = 0);
  var i,block, ShapeLeft, ShapeTop: Integer;
  begin
    ShapeLeft := 0;
    ShapeTop := 4 + top;
    block:=10;
    for i:=1 to n do
    begin
      Image1.Canvas.Pen.Width := 4;
      Image1.Canvas.Pen.Color := clWhite;
      Image1.Canvas.Brush.Color := clWhite;
      ShapeLeft := ShapeLeft+50;
      Image1.Canvas.Rectangle(ShapeLeft, ShapeTop, ShapeLeft+50, ShapeTop+50);
      Image1.Canvas.Font.Size := 7;

      if i=block then
      begin
        ShapeTop:=ShapeTop+50;
        ShapeLeft:=0;
        block:=block+10;
      end;
    end;
  end;
end.
