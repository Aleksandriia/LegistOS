   M S B A M L   `   `   `  ����C  ?LegistOS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:LegistOS.StraniciLegistOS.Stranici  5      '    !LegistOS.Stranici.DocumentIzbrann   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:LegistOS.Stranici     5        N� Title$)  #Избранный документ��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��95 �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ BtnNazad��5      $��
Назад��6#   $��20q�5   (   $��0��5      $��0��6!   $	��Top=�6.      	BtnDeistv#��[  5      �� 5   
    �� Orientation$ Vertical=�6   $��0��5      $��1��6"   .+�5      �� $ 
Horizontal=�6   .+�5      �� -   5         ��Name$ TBlDocNomer��5      $��Документ №��61     TBlZagolovokDoc#��[ 5      $��20q�5       $��SemiBold"�6(   �� 5!      -   5        $ TBlNomerDoc��5!      $��SemiBold"�6H   #��[ 5"      $��
-10,20,0,0q�6E   ��5!   1   �� *Nomer+5"   E   5#      �� 5$      -   5        $ TBlNazvanieDoc��5$      #��[ 5%      $��
20,-10,0,0q�5&      $��SemiBold"�6,   ��5$   0   �� *
Nazvanie+5&   ,   5'      �� 5)   
   -   5         ��Name$ 
TBOpisanie��5*      $��1��5)      $��2��6"    �� 
IsReadOnly .   TBOpisanieDoc#��[ 5+      $
��Auto=�5,      $
��Auto=�5-       � Cursor$ IBeam��6B   �� 50   
   $ Vertical=�6   $��0��51      $��2��6%   .+�52      �� $ 
Horizontal=�6   .+�53      �� -   5        $ TBlDocStatus��53      $��Статус:��62     TBlInfBokIzn#��[ 54      $��	10,20,0,0q�6B   �� 55      -   5        $ TBlStatusDoc��55        	TBlStatus#��[ 56      $��5,20,0,0q�6?   ��57      �� *DDocument.status+58      �� 5:      $ 
Horizontal=�6   .+�5;      �� -   5        $ 	TBlDocVid��5;      $��Вид:��6/   #��[ 5<      $��	10,10,0,0q�6B   �� 5=      -	   5        $ 	TBlVidDoc��5=        	TBlBokIng#��[ 5>      $��5,10,0,0q�6?   5?      �� 5H      $ 
Horizontal=�6   .+�5I      �� -
   5        $ TBlDocPravBaza��5I      $ ��Правовая база:��64   #��[ 5J      $��	10,10,0,0q�6B   �� 5K      -   5        $ TBlPravBazaDoc��5K      #��[ 5L      $��5,10,0,0q�6?   $��90��6Q   5M      �� 5O      $ 
Horizontal=�6   .+�5P      �� -   5        $ TBlDocRegion��5P      $��Регион:��62   #��[ 5Q      $��	10,10,0,0q�6B   �� 5R      -   5        $ TBlRegionDoc��5R      #��[ 5S      $��5,10,0,0q�6?   5T      �� 5V      -   5        $ TBlDocIzdOrgan��5V      $"��Издавший орган:��60   #��[ 5W      $��	10,10,0,0q�6>   �� 5X      -   5        $ TBlIzdOrganDoc��5X      #��[ 5Y      $��
-10,10,0,0q�6;   $	��200��6O   �� 5[      $ Vertical=�6   .+�5\      �� $ 
Horizontal=�6   .+�5]      �� -   5        $ TBlDocDataNach��5]       $��Дата начала:��68   #��[ 5^      $��	10,10,0,0q�6>   �� 5_      -   5        $ TBlDocDataKonca��5_       $��Дата конца:��69   #��[ 5`      $��	15,10,0,0q�6>   5a      �� 5c      $ 
Horizontal=�6   .+�5e      �� -   5        $ TBlDataNachDoc��5e       #��[ 5f      $��	10,10,0,0q�6;   $��80��6N   �� 5g      -   5        $ TBlDataKoncaDoc��5g       #��[ 5h      $��	10,10,0,0q�6;   $��80��6N   $��80��6Y   5i      5j      5k      5l      5m      