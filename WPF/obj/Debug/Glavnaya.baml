   M S B A M L   `   `   `  ????A  =Wpf3_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Wpf3_1Wpf3_1  5   	       Wpf3_1.Glavnaya   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Wpf3_1     5   	   -   5          ? Title$  Главная??5   	   $	??450??6   $	??800??6&   .??5	      ? .+?5
   
   &   System.Windows.Controls.DataGrid  -   5        $??DG_departament??5
   H      
IsReadOnly .  ?? SelectedValuePath$ inn_departamen??6%   $
??Left=?6^   $	??282??6y   $??
108,38,0,0q?6?   $	??Top=?6?   $	??444??6?      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ inn_departamen??6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ?? *inn_departamen+6H     5      $ name_departament??6J    6%   ?? *name_departament+6J     5      $ street??6L    6%   ?? *street_departament+6L     5      $
 home??6J    6%   ?? *home_departament+6J     5      $
 town??6J    6%   ?? *town_departament+6J     5      $ phone??6M    6'   ?? *phone_departament+6M   5      ?? 5   
   -   5        $??TB_inn_departament??5      $
??Left=?6{   $??23??6?   $??
648,10,0,0q?6?    ?? TextWrapping$
 Wrap=?6?   $	??Top=?6?   $	??120??6?   ??6-   ??  ?? ElementName$ DG_departament??	 ?? Path$!	 SelectedItem.inn_departamen?6?   ?? 5   
   -   5        
 ??Name$
 TB_name_departament??5      $
??Left=?6?   $??23??6?   $??
648,38,0,0q?6?   $
 Wrap=?6?   $	??Top=?6?   $	??120??6?   ??60   ?? $ DG_departament??$#	 SelectedItem.name_departament?6?   ?? 5   
   -   5        $
 TB_street_departament??5      $
??Left=?6   $??23??6?   $??
648,66,0,0q?6?   $
 Wrap=?6?   $	??Top=?6?   $	??120??6?   ??62   ?? *!SelectedItem.street_departament+$ DG_departament??6?   ?? 5   
   -   5        $
 TB_home_departament??5      $
??Left=?6{   $??23??6?   $??
648,94,0,0q?6?   $
 Wrap=?6?   $	??Top=?6?   $	??120??6?   ??60   ?? *SelectedItem.home_departament+$ DG_departament??6?   ?? 5   
   -   5        $
 TB_town_departament??5      $
??Left=?6{   $??23??6?   $??648,122,0,0q?6?   $
 Wrap=?6?   $	??Top=?6?   $	??120??6?   ??60   ?? *SelectedItem.town_departament+$ DG_departament??6?   ?? 5   
   -   5        $
 TB_phone_departament??5      $
??Left=?6}   $??23??6?   $??648,150,0,0q?6?   $
 Wrap=?6?   $	??Top=?6?   $	??120??6?   ??61   ?? * SelectedItem.phone_departament+$ DG_departament??6?   ?? 5   
   -	   5        $??	AddButton??5      $	??Add??6   $
??Left=?60   $??648,192,0,0q?6K   $	??Top=?6`   $	??120??6x   $??21??6?   ?? 5   
   -
   5         ??Name$ Update??5   "   $??Update??6   $
??Left=?62   $??648,223,0,0q?6M   $	??Top=?6b   $	??120??6z   $??21??6?   ?? 5   
   -   5        $ Update_Copy??5   "   $??Delete??6   $
??Left=?67   $??648,255,0,0q?6R   $	??Top=?6g   $	??120??6   6?   ?? 5   
   -   5        $??CB_innn??5      $ inn_departamen??6#    ?? DisplayMemberPath$ name_departament??6F   $
??Left=?6k   $??648,280,0,0q?6?   $	??Top=?6?   $	??120??6?   6?   ?? 5   
   -   5        $
 Search??5      $
??Left=?6C   $??23??6^   $??
162,10,0,0q?6j   $
 Wrap=?6~   $	??Top=?6?   $	??390??6?   5      5       