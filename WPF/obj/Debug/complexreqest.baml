   M S B A M L   `   `   `  ????A  =Wpf3_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Wpf3_1Wpf3_1  5   	       Wpf3_1.complexreqest   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Wpf3_1     5   	   -   5          ? Title$  Сертификат??5   	   $??365.588??6   $??819.294??6-   .??5	      ? .+?5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgcomplexreqest??5
         AutoGenerateColumns .  $
??Left=?6H   $	??279??6c   $??	10,27,0,0q?6p   $	??Top=?6?   $	??643??6?      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия??6A   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ?? *	surname+6A     5      $ Имя??6?    6%   ?? *namee+6?     5      $ Отчество??6D    6%   ?? *
patronymic+6D     5      $' !Номер сертификата??6J    6%   ?? *numb_certificate+6J     5      $ Дата выдачи??6D    6%   ?? *
date_issue+6D     5      $: 4ИНН отдела Роспотребнадзора??6M    6%   ?? *inn_departament_rsp+6M     5      $ ИНН компании??6E    6%   ?? *inn_company+6E   5      (  "System.Windows.Controls.DatePicker  5   
   -   5        $
??dpst??5      $
??Left=?6!   $??
673,28,0,0q?6<   $	??Top=?6P     5   
   -   5        $??dpfin??5      $
??Left=?6"   $??
673,57,0,0q?6=   $	??Top=?6Q   ?? 5   
   -   5        $??ExcelButton??5      $??Excel??6$   $
??Left=?64   $??
698,86,0,0q?6O   $	??Top=?6c   $??75??6{   6?   5      5      