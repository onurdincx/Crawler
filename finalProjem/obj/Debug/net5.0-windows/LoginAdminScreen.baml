   M S B A M L   `   `   `  ����F  BfinalProjem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:finalProjemfinalProjem  5   	   "    finalProjem.LoginAdminScreen   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:finalProjem     5   	     � Title$  LoginAdminScreen��5      $	��450��6'   $	��800��64    � WindowStyle$
 None=�6@    � 
ResizeMode$ NoResize=�6S   $
��True��6i    � WindowStartupLocation$ CenterScreen=�6�   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ Black��6    � Offset$ 1Q�6)   � 5      $ 	#FF7A0404��6   $ 0.037Q�6-   5      .��5      � .+�5   
   �� -   5         ��Name$ txt_adminusername��5      $��Center=�6-   $��0,65,0,0q�6J   	 �� TextWrapping$
	 Wrap=�6\   $	��Top=�6p   $	��256��6�   $��29��6�   $��18(�6�   
 �� TextAlignment$
 Center=�6�   �� 5   
   -   5        $ txt_adminpassword��5      $��Center=�6-   $��	0,131,0,0q�6J   $
	 Wrap=�6]   $	��Top=�6q   $	��256��6�   $��29��6�   $��18(�6�   $
 Center=�6�   �� 5   
   $��
User Name:��6   $
��Left=�6%   $��	67,57,0,0q�6@   $	��Top=�6S   $	��287��6k   $��49��6w   $��30(�6�   $��Segoe UI Black)�6�   ���	#FF46FF00��6�   Z� 6�   �� 5   
   $��	Password:��6   $
��Left=�6$   $��
89,123,0,0q�6?   $	��Top=�6S   $	��287��6k   $��49��6w   $��30(�6�   $��Segoe UI Black)�6�   ���	#FF46FF00��6�   Z� 6�   �� 5   
   -   5         ��Name$ 	Btn_Login��5      $��Login!��6$   $��Center=�65   $��	0,196,0,0q�6R   $	��Top=�6e   $��89��6}   $	��256��6�   $��Arial Black)�6�   $��36(�6�   ���	#FF0CFF00��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ Black��6#   � 5      $ Black��6#   $ 0Q�61   � 5      $ Black��6#   $ 1Q�61   � 5      $ 	#FF0023FF��6#   $ 0.377Q�65   � 5      $
 Blue��6#   $ 0.719Q�60   5      5      �� 5   
   -   5        $ 	Btn_Close��5      $
��EXIT��6$   $
��Left=�63   $��530,361,0,0q�6N   $	��Top=�6c   $��89��6{   $	��148��6�   $��Arial Black)�6�   $��36(�6�   
���   ���5       �� 5!      $ 0.5,1&�6&   $ 0.5,0&�67   .��5"      � $ Black��6#   � 5#      $ Black��6#   $ 0Q�61   � 5$      $ 	#FF363636��6#   $ 1Q�65   � 5%      $	 Red��6#   $ 0.377Q�6/   � 5&      $	 Red��6#   $ 0.719Q�6/   5'      5)      �� 5*   
   -   5        $ txt_AdminRule��5*      $
��Left=�6)   $��534,194,0,0q�6D   $
	 Wrap=�6Y   $	��Top=�6m   $	��120��6�   $��Admin��6�   $y�Hidden=�6�   5,      5-      