   M S B A M L   `   `   `  ����C  ?LegistOS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:LegistOS.StraniciLegistOS.Stranici  5           LegistOS.Stranici.Document   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:LegistOS.Stranici     5        N� Title$  Документ��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��35 �6   �� 5      $��95 �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��0��6%      PodlojkaBel#��[  62   .+�5      �� -   5         ��Name$ TBZagolovokNP��5   (   $��Документ��6     TBlZagolovok#��[ 5      $
��Left=�5      $��Center=�63   5      �� 5   
   #��[  6   $��0��68   $��3��6H   �� 5   
   -   5         ��Name$ BtnNazad��5      $��
Назад��6#   $��20q�5   (   $��0��5       $��1��6!   $	��Top=�6.     	BtnDeistv#��[ 5!      �� 5$   
    �� Orientation$ Vertical=�6   $��1��5%      $��1��6"   .+�5&      �� $ 
Horizontal=�6   .+�5'      �� -   5        $ TBlDocNomer��5'      $��Документ №��61     TBlZagolovokDoc#��[ 5(      $��20q�5)      $��SemiBold"�6(   �� 5*      -   5        $ TBlNomerDoc��5*      $��SemiBold"�6H   #��[ 5+      $��
-10,20,0,0q�6E   ��5*   1   �� *Nomer+5+   E   5,      �� 5-      -   5        $ TBlNazvanieDoc��5-      #��[ 5.      $��
20,-10,0,0q�5/      $��SemiBold"�6,   ��5-   0   �� *
Nazvanie+5/   ,   50      �� 52   
   -   5        $ BtnIzbranDob��52        	BtnRegMal#��[ 53      $��1��54      $��1��6   $	��Top=�55      $��Right=�6)    � ToolTip$, &Добавить в избранное��56      .��57      �� $_��Y/Izobragenia/Znachki/streamline-interface-bookmark-double--interface-essential--48x48.PNG��6   $��18��58      59      �� 5;   
   -   5         ��Name$ 
TBOpisanie��5<      $��1��5;      $��2��6"    �� 
IsReadOnly .   TBOpisanieDoc#��[ 5=      $
��Auto=�5>      $
��Auto=�5?      	 � Cursor$	 IBeam��6B   �� 5C   
   $ Vertical=�6   $��0��5D      $��2��6%   .+�5E      �� $ 
Horizontal=�6   .+�5F      �� -   5        $ TBlDocStatus��5F      $��Статус:��62     TBlInfBokIzn#��[ 5G      $��	10,20,0,0q�6B   �� 5H      -	   5        $ TBlStatusDoc��5H        	TBlStatus#��[ 5I      $��5,20,0,0q�6?   ��5J      �� *DDocument.status+5K      �� 5M      $ 
Horizontal=�6   .+�5N      �� -
   5        $ 	TBlDocVid��5N      $��Вид:��6/   #��[ 5O      $��	10,10,0,0q�6B   �� 5P      -   5        $ 	TBlVidDoc��5P        	TBlBokIng#��[ 5Q      $��5,10,0,0q�6?   5R      �� 5[      $ 
Horizontal=�6   .+�5\      �� -   5        $ TBlDocPravBaza��5\      $ ��Правовая база:��64   #��[ 5]      $��	10,10,0,0q�6B   �� 5^      -   5        $ TBlPravBazaDoc��5^      #��[ 5_      $��5,10,0,0q�6?   $��90��6Q   5`      �� 5b      $ 
Horizontal=�6   .+�5c      �� -   5        $ TBlDocRegion��5c      $��Регион:��62   #��[ 5d      $��	10,10,0,0q�6B   �� 5e      -   5        $ TBlRegionDoc��5e      #��[ 5f      $��5,10,0,0q�6?   5g      �� 5i      -   5        $ TBlDocIzdOrgan��5i      $"��Издавший орган:��60   #��[ 5j      $��	10,10,0,0q�6>   �� 5k      -   5        $ TBlIzdOrganDoc��5k      #��[ 5l      $��
-10,10,0,0q�6;   $	��200��6O   �� 5n      $ Vertical=�6   .+�5o      �� $ 
Horizontal=�6   .+�5p      �� -   5        $ TBlDocDataNach��5p       $��Дата начала:��68   #��[ 5q      $��	10,10,0,0q�6>   �� 5r      -   5        $ TBlDocDataKonca��5r       $��Дата конца:��69   #��[ 5s      $��	15,10,0,0q�6>   5t      �� 5v      $ 
Horizontal=�6   .+�5x      �� -   5        $ TBlDataNachDoc��5x       #��[ 5y      $��	10,10,0,0q�6;   $��80��6N   �� 5z      -   5        $ TBlDataKoncaDoc��5z       #��[ 5{      $��	10,10,0,0q�6;   $��80��6N   $��80��6Y   5|      5}      5~      5      5�      