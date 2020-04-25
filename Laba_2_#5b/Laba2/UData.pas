unit UData;

interface

  uses
    Grids,Classes,SysUtils;

  type
    TKey=string[50];

    TInfo=record
            Key:TKey;
            FIO:string[50];
            Address:string[50];
          end;

    TFile=File of TInfo;

  Function IsEqualKeys(const k1,k2:Tkey):boolean;
  Function LoadFromFile(var f:TFile; var info:TInfo):boolean;
  Procedure SaveToFile(var f:TFile; const Info:Tinfo);
  Function HF(Key:TKey):integer;
  Function PrintToGrid(info:TInfo):TStrings;
  Function StringsToInfo(Str:TStrings):TInfo;
  Function IsEqualInfo(const i1,i2:TInfo):boolean;
  Procedure InitInfo(var info:TInfo);
  Function GridTitle:TStrings;

implementation

Function StringsToInfo(Str:TStrings):TInfo;
begin
  with result do
    begin
      Key:=Str[0];
      FIO:=Str[1];
      Address:=Str[2];
    end;
end;

Procedure InitInfo(var info:TInfo);
begin
  with info do
    begin
      Key:='';
      FIO:='';
      Address:='';
    end;
end;

Function PrintToGrid(Info:TInfo):TStrings;
begin
  result:=TStringList.Create;
  with Info do
    begin
      result.Add(Key);
      result.Add(FIO);
      result.Add(Address);
    end;

end;

Function IsEqualKeys(const k1,k2:Tkey):boolean;
begin
  result:=(k1=k2);
end;

Function IsEqualInfo(const i1,i2:TInfo):boolean;
begin
  result:=IsEqualKeys(i1.Key,i2.Key) and (i1.FIO=i2.FIO) and (i1.Address=i2.Address);
end;

Function LoadFromFile(var f:TFile; var info:TInfo):boolean;
begin
  result:=true;
  try
    read(f,info);
  except
    result:=false;
  end;
end;

Procedure SaveToFile(var f:TFile; const Info:Tinfo);
begin
  write(f,info);
end;

Function HF(key:TKey):integer;
var
  i:integer;
begin
  result:=0;
  for i := 0 to length(key) - 1 do
    result:=result + ord(key[i])*i;
end;

Function GridTitle:TStrings;
begin
  result:=TStringList.Create;
  result.Add('Номер телефона');
  result.Add('ФИО');
  result.Add('Адрес');
end;

end.
