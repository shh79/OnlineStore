   M S B A M L   `   `   `  ����I  EOnlineStoreWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:OnlineStoreWPFOnlineStoreWPF  5   	       OnlineStoreWPF.ChangePass   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:OnlineStoreWPF     5   	     � Title$  
ChangePass��5   	   $��331.635��6   $��614.455��6-    � AllowsTransparency .  � WindowStyle$
 None=�6W    � WindowStartupLocation$ CenterScreen=�6j    � Icon$ img/AdminLogIcon.jpg��6�   ��5	      �� 5
   
    �� ImageSource$ img/CHPass.jpg��6   .��5      � .+�5   
   �� -   5         ��Name$ History��5       �� 
IsReadOnly . $
��Left=�65   $	��266��6P   $��	28,40,0,0q�6]    �� TextWrapping$
 Wrap=�6p   $�� ��6�   $	��Top=�6�   $	��221��6�   G� 5   
   -   5        	 G�Name$	 CurrentPass��5      $
��Left=�6+   $��
419,59,0,0q�6F   $	��Top=�6Z   $	��166��6r   $��31��6~   
 G� Password$
  ��6�   $��18(�6�   G� 5   
   -   5        $	 NewPass��5      $
��Left=�6'   $��419,122,0,0q�6B   $	��Top=�6W   $	��166��6o   $��31��6{   $
  ��6�   $��18(�6�   6�   G� 5   
   -   5        $	 RNPass��5      $
��Left=�6&   $��419,185,0,0q�6A   $	��Top=�6V   $	��166��6n   $��31��6z   $
  ��6�   $��18(�6�   6�   �� 5   
   $
��Left=�6   $��
270,59,0,0q�6/   $
��Wrap=�6C   $��Current Pass :��6W   $	��Top=�6m   $��31��6�   $	��144��6�   $��22(�6�   $��Andalus)�6�   $
��Bold"�6�   ���	#FF970D0D��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF2AB1CA��6#    � Offset$ 0Q�65   � 5      $ 	#FFE8877F��6#   $ 1Q�65   5      5      �� 5   
   $
��Left=�6   $��270,185,0,0q�6/   $
��Wrap=�6D   $��Repeat Pass :��6X   $	��Top=�6m   $��31��6�   $	��144��6�   $��22(�6�   $��Andalus)�6�   $
��Bold"�6�   ���	#FF970D0D��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ 	#FF2AB1CA��6#   $ 0Q�65   � 5      $ 	#FFE8877F��6#   $ 1Q�65   5      5       �� 5"   
   $
��Left=�6   $��270,122,0,0q�6/   $
��Wrap=�6D   $��
New Pass :��6X   $	��Top=�6j   $��31��6�   $	��144��6�   $��22(�6�   $��Andalus)�6�   $
��Bold"�6�   ���	#FF970D0D��5#      �� 5$      $ 0.5,1&�6&   $ 0.5,0&�67   .��5%      � $ 	#FF2AB1CA��6#   $ 0Q�65   � 5&      $ 	#FFE8877F��6#   $ 1Q�65   5'      5)      �� 5+   
   -   5         ��Name$ backbtn��5+      $
��Back��6"   $
��Left=�61   $��270,266,0,0q�6L   $	��Top=�6a   $��97��6y   $��40��6�   ���	#FF93FFFD���	#FF92305C$��Adobe Myungjo Std M)�6�   $��19(�6�   �� 5,   
   -   5        $ 
confirmbtn��5,      {�.  $��Confirm��67   $
��Left=�6I   $��485,266,0,0q�6d   $	��Top=�6y   $	��100��6�   $��40��6�   ���	#FF93FFFD���	#FF92305C$��Adobe Myungjo Std M)�6�   $��19(�6  �� 5.   
   -   5        $	 New��5.      $	��New��6   $
��Left=�6,   $��389,266,0,0q�6G   $	��Top=�6\   $��71��6t   $��40��6   ���	#FF93FFFD���	#FF92305C$��Adobe Myungjo Std M)�6�   $��19(�6�   52      53      