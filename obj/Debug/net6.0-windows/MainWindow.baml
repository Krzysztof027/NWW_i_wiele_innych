   M S B A M L   `   `   `  ����F  BUklady_3_08, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Uklady_3_08Uklady_3_08  5   	       Uklady_3_08.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Uklady_3_08     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      ]� -   5         ]�Name$ Dock1��5	   '   
����ح�.+�5
   
   o� $	��Top=�6   .@�5      m� $
��Plik��6   .@�5      m� -   5        $��Powieksz czcionkę��5      6E   m� 5      -   5         m�Name$ zapis��5   /   $��Zapis do pliku��6   6O   m� 5      -   5        $��oblicz��5      68   m� 5      -   5        $��Pokaz liczby��5      6G   5      m� 5      $��Koloruj��6   .@�5      m� -   5        $��Zmien kolor tekstu��5      $��Oblique$�67   
����� �6|   5      5      �� 5   
   $	��Top=�6   $
��Bold"�6)   Podaj tekst poniżej6P   �� 5   
   -   5         ��Name$ tekstDoZapisu��5      $	��200��6*    �� TextWrapping$
 Wrap=�66    �� AcceptsReturn$
 True��6J   6a   � 5*   
    � ColumnDefinitions 5+      �� 5,      6%   �� 5-      6%    � RowDefinitions 51      �� 52      �� 53      �� 54      6"   .+�5:      �� $��0��6   $��0��6%   Wpisz 1 liczbę5<      �� 5=      $��1��6   $��0��6%   Wpisz 2 liczbę5?      �� 5C      -   5        $ liczba1��5C   3   $��0��6   $��1��6#   6F   �� 5D      -	   5        $ liczba2��5D   3   $��1��6   $��1��6#   6F   �� 5G      -
   5        $��2��5G      $��1��6"   $��Center=�66   $��Center=�5H      .��64   NWW69   �� 5M      -   5        $��2��5M      $��2��6"   $��10q�66   
����� �$��Center=�5N      $��Center=�66   .��6S   Zagraj w QUIZ6b   5P      5R      5S      