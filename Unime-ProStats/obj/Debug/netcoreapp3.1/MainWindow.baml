   M S B A M L   `   `   `  ����I  EUnime-ProStats, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Unime_ProStatsUnime_ProStats  5   	   X TXceed.Wpf.Toolkit, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4P:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.ToolkitXceed.Wpf.Toolkit 5	   	       Unime_ProStats.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Unime_ProStats     5   	   NwpfTool:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.Toolkit     5	   	   -   5        $��MainWin��5
   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5      ��%    5      .��5      �    BackgroundColor#��[  6   .+�5   
   �� $��Visible=�6   $��	0 20 0 20q�6=   .��5      � $��	40 0 40 0q�6   $
��1200��6&    � RowDefinitions 5      �� 5      $��50 �6$   �� 5      .+�5      �� $��0��5        Layer2Color#��[ 5       �� CornerRadius$ 10��5      $��30��5      $	��Top=�5      ._�5      �  � ColumnDefinitions 5      �� 5      �� 5       $	��200 �6/   .+�5"      (  "Xceed.Wpf.Toolkit.WatermarkTextBox  -   5          Name$ ProfileName_TxtBx��5"   3      	Watermark$ Profile Name��5#      
�������$��0��5%      $��Stretch=�5&      $��	3 -1 10 0q�5(      $��0q�5*      $��20(�5+       �� 
CaretBrush
 �������5'      Z� ��5)      Z� 5,      �� 5-      -   5         ��Name$ Load_Btn��5-   !     ImportantButton#���  63     ButtonImportant#��[ 6`   $��1��5.      $��0q�5/      $��Stretch=�50      $��Stretch=�51      $��0 0 0 0q�52      .��53      �� $��Load Profile��6(   ���#121212$��20(�6Q   54      55      56      �� 5?      $	��Top=�6   	 �� Padding$	 5q�61     BorderRadius# [ 6=   $��1��6j   #��[ 6w   ._�5@      �� .+�5A      9� -   5        $��ExpanderAnimeList��5A   #   $��Stretch=�5B      $	��Top=�67   
 9� ExpandDirection$

 Down=�5C        	Template1#��[ 5D      $��1��5E      $��
Anime List��5G      
�������$��18(�5I       9� 
IsExpanded$
 True��5J        MarginSameRadius#��[ 5K      ��5F      Z� .��5L      �� .+�5N   "   � $��LeftToRight=�6,    � Orientation$ 
Horizontal=�6H   $��Center=�6a   .+�5O   &   ��   Layer3Color#��[ 6-   # [ 5P   )   $	 5q�5Q   )   $��5q�65   ._�5R   *   �� $��15(�65   .+�5S   .   �� $��Sort Direction��68   
�������$��16(�6a   $
��Bold"�6o   	� 5T   .   -   5         	�Name$ Ascending_RB��5T   K    d� 	IsChecked$
 TrueY�6:     MaterialDesignRadioButton#��[ 6a   .��5U   2   �� $��	Ascending��6<   
�������6M   5V   /   	� 5W   .   -   5        $ Descending_RB��5W   :   #��[ 6Q   .��5X   2   �� $��
Descending��6<   
�������6N   5Y   /   5Z   +   5[   '   �� 5\   &   #��[ 6-   # [ 5]   )   $	 5q�5^   )   $��5q�65   $
��Left=�6@   ._�5_   *   �� $��15(�65   .+�5`   .   �� $��Title Contains��68   
�������$��16(�6a   $
��Bold"�6o   �� 5a   .   $��0 3 0 0q�65   $��30��6F   $	��200��6R   #��[ 6^   # [ 6�   ._�5b   2     -   5        $ 
Keyword_TB��5b   K   
 �����
�������$��15(�6�   $��3 2 3 0q�6�   $	��200��6�   $��0q�6�   $ Keyword��6�   ��6�   Z� 6�   5c   /   5d   +   5e   '   �� 5f   &   #��[ 6-   # [ 5g   )   $	 5q�5h   )   $��5q�65   ._�5i   *   �� $��15(�65   .+�5j   .   �� $��Sort By��68   
�������$��16(�6Z   $
��Bold"�6h   	� 5k   .   -   5        $ Title_RB��5k   K   $
 TrueY�6:   #��[ 6]   .��5l   2   �� $��Title��6<   
�������6I   5m   /   	� 5n   .   -	   5        $ TotalEpisodes_RB��5n   :   #��[ 6T   .��5o   2   �� $��Total Episodes��6<   
�������6R   5p   /   	� 5q   .   -
   5        $ WathcedEpisodes_RB��5q   :   #��[ 6V   .��5r   2   �� $��Watched Episodes��6<   
�������6T   5s   /   	� 5t   .   -   5        $ 	Rating_RB��5t   :   #��[ 6M   .��5u   2   �� $��Rating��6<   
�������6J   5v   /   	� 5w   .   -   5        $ Score_RB��5w   :   #��[ 6L   .��5x   2   �� $��Score��6<   
�������6I   5y   /   5z   +   5{   '   5|   #   �� 5}   "   -   5        $��FullAnimeListBox��5�   &   $��10q�5   &   $	��750��5�   &   $��Center=�5�   .   $��Disabled=�5�   &   $��Visible=�5�   &    	 	AnimeItem#��[	 5�   &   ��5}   *   Z� ��5~   &   Z� ��5�   &   ��  �� Path$ CurrentProfile.animeList���5�   &   �� 5�   *   .R�5�   .   � $ 
Horizontal=�68   5�   +   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      