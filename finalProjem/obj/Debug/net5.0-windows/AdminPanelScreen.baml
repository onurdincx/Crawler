   M S B A M L   `   `   `  ����F  BfinalProjem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:finalProjemfinalProjem  5   	   "    finalProjem.AdminPanelScreen   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:finalProjem     5   	     � Title$  AdminPanelScreen��5   	   $	��450��6"   $	��800��6/    � WindowStyle$
 None=�6;    � 
ResizeMode$ NoResize=�6N   $
��True��6d    � WindowStartupLocation$ CenterScreen=�6�   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ Black��6    � Offset$ 1Q�6)   � 5      $ 	#FF7A0404��6   $ 0.037Q�6-   5      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ member_datagrid��5      $��10,72,446,75q�6,     5   
   -   5        $ crawled_datagrid��5      $��413,73,10,75q�6-   �� 5   
   $��Members:��6   $
��Left=�6#   $��	10,10,0,0q�6>   $	��Top=�6Q   $��67��6i   $	��323��6u   $��36(�6�   $��Segoe UI Black)�6�   �� 5   
   $��Crawled Links:��6   $
��Left=�6)   $��
413,10,0,0q�6D   $	��Top=�6X   $��67��6p   $	��323��6|   $��36(�6�   $��Segoe UI Black)�6�   �� 5   
   -   5        	 ��Name$	 Btn_delete_member��5      $��DELETE��6,   $
��Left=�6=   $��
93,380,0,0q�6X   $	��Top=�6l   $��70��6�   $	��178��6�   $��Arial Black)�6�   $��24(�6�   ���	#FF00FF2E��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ Black��6#   � 5      $ 	#FF002EFF��6#   � 5      $ 	#FF002EFF��6#   $ 1Q�65   � 5      $	 Red��6#   $ 0.377Q�6/   � 5      $	 Red��6#   $ 0.719Q�6/   5      5      �� 5   
   -   5        $	 Btn_delete_crawled��5      $��DELETE��6-   $
��Left=�6>   $��512,380,0,0q�6Y   $	��Top=�6n   $��70��6�   $	��178��6�   $��Arial Black)�6�   $��24(�6�   ���	#FF00FF2E��5       �� 5!      $ 0.5,1&�6&   $ 0.5,0&�67   .��5"      � $ Black��6#   � 5#      $ 	#FF002EFF��6#   � 5$      $ 	#FF002EFF��6#   $ 1Q�65   � 5%      $	 Red��6#   $ 0.377Q�6/   � 5&      $	 Red��6#   $ 0.719Q�6/   5'      5)      �� 5*   
   -   5        $	 	Btn_Close��5*      $
��EXIT��6$   $
��Left=�63   $��312,380,0,0q�6N   $	��Top=�6c   $��70��6{   $	��148��6�   $��Arial Black)�6�   $��36(�6�   
���   ���5+      �� 5,      $ 0.5,1&�6&   $ 0.5,0&�67   .��5-      � $ Black��6#   � 5.      $ Black��6#   $ 0Q�61   � 5/      $ 	#FF363636��6#   $ 1Q�65   � 50      $	 Red��6#   $ 0.377Q�6/   � 51      $	 Red��6#   $ 0.719Q�6/   52      54      55      56      