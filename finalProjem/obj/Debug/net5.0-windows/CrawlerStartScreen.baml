   M S B A M L   `   `   `  ����F  BfinalProjem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:finalProjemfinalProjem  5   	   $    finalProjem.CrawlerStartScreen   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:finalProjem     5   	     � Title$  CrawlerStartScreen��5   	   $	��450��6$   $	��800��61    � WindowStyle$
 None=�6=    � 
ResizeMode$ NoResize=�6P   $
��True��6f    � WindowStartupLocation$ CenterScreen=�6�   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ Black��6    � Offset$ 1Q�6)   � 5      $ 	#FF7A0404��6   $ 0.037Q�6-   5      .��5      � .+�5   
   �� -   5         ��Name$ combobx1��5      $
��Left=�6%   $��	10,30,0,0q�6@   $	��Top=�6S   $	��309��6k   $��38��6w   �� 5   
   -   5        	 ��Name$	 lstbox1��5      $��10,73,481,100q�6#   �� 5   
   -   5        
 ��Name$
 	Btn_Close��5      $��	Sign Out!��6$   $
��Left=�68   $��530,361,0,0q�6S   $	��Top=�6h   $��89��6�   $	��148��6�   $��Arial Black)�6�   $��24(�6�   
���   ���5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ Black��6#   � 5      $ Black��6#   $ 0Q�61   � 5      $ 	#FF363636��6#   $ 1Q�65   � 5      $	 Red��6#   $ 0.377Q�6/   � 5      $	 Red��6#   $ 0.719Q�6/   5      5      �� 5   
   -   5        $
 	Btn_Start��5      $��START��6$   $
��Left=�64   $��
336,30,0,0q�6O   $	��Top=�6c   $��39��6{   $	��140��6�   $��Arial Black)�6�   $��36(�6�   ���	#FF90FF0A��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5       � $ Black��6#   � 5!      $ White��6#   $ 0Q�61   � 5"      $ White��6#   $ 1Q�61   � 5#      $	 Red��6#   $ 0.377Q�6/   � 5$      $	 Red��6#   $ 0.719Q�6/   5%      5'      &   System.Windows.Controls.DataGrid  5(   
   -   5          Name$ crawledlinks_datagrid��5(      $��400,73,10,100q�62   �� 5)   
   $��Crawled Links:��6   $
��Left=�6)   $��
494,20,0,0q�6D   $	��Top=�6X   $��58��6p   $	��284��6|   $��36(�6�   $��Segoe UI Black)�6�   ��5*      �� 5+      $ 0.5,1&�6&   $ 0.5,0&�67   .��5,      � $ 	#FF00FF5D��6#   � 5-      $ White��6#   $ 1Q�61   5.      50      �� 51   
   -   5         ��Name$ onlineusernamelbl��51      $�� ��6+   $
��Left=�66   $��141,411,0,0q�6Q   $	��Top=�6f   $��39��6~   $	��340��6�   
���  ��$��20(�6�   �� 52   
   $��Online User:��6   $
��Left=�6'   $��
10,411,0,0q�6B   $	��Top=�6V   $	��131��6n   
���  ��$��39��6�   $��20(�6�   $��Segoe UI Black)�6�   53      54      