   M S B A M L   `   `   `  ����I  EOnlineStoreWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:OnlineStoreWPFOnlineStoreWPF  5   	       OnlineStoreWPF.AdminPanel   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:OnlineStoreWPF     5   	     � Title$  
AdminPanel��5   	   $	��450��6   $��686.967��6)    � Icon$ img/AdminLogIcon.jpg��69    � AllowsTransparency .  � WindowStyle$
 None=�6o    � WindowStartupLocation$ CenterScreen=�6�   ��5	      �� 5
   
    �� ImageSource$ img/AdminPP.jpg��6   .��5      � .+�5   
   �� -   5         ��Name$ exitbtn��5      $
��Exit��6"   $
��Left=�61   $��
30,384,0,0q�6L   $	��Top=�6`   $��70��6x   $��40��6�   ���	#FF93FFFD���	#FF92305C$��Adobe Myungjo Std M)�6�   $��19(�6�   ]� 5   
   $
��Left=�6   $��35��6/   ��.  $	��Top=�6Q   $	��687��6i   
���   �.+�5      �� -   5         ��Name$ 
AdminEmail��5       J� IsHitTestVisible .  $��35��6C   	 �� TextWrapping$
	 Wrap=�6O   $��Email��6c   $	��Top=�6p   $	��687��6�   
�������
���   �
 �� TextAlignment$
 Center=�6�   $��20(�6�   $��Andalus)�6�   ��6�   Z�  �� SelectionBrush 6  Z� 5      �� 5   
   $��35��6   $	��Top=�6   $��0,0,652.2,0q�64   $��img/AdminLogIcon.jpg��6I   �� 5   
   -   5         ��Name$ 	GoodsList��5      $
��Left=�6%   $	��194��6@   $��
30,140,0,0q�6M   $	��Top=�6a   $	��408��6y   �� 5   
   -   5        $ 	Searchbar��5      $
��Left=�6P   $��35��6k   $��
100,90,0,0q�6w   $
	 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��237��6�   $��22(�6�   �� 5   
   -   5        $ 	searchbtn��5      $��Search��6$   $
��Left=�65   $��
368,90,0,0q�6P   $	��Top=�6d   $��70��6|   $��35��6�   ���	#FF93FFFD���	#FF92305C$��Adobe Myungjo Std M)�6�   $��19(�6�   �� 5   
   -   5        $ Showbtn��5      $��Show Customers��6"   $
��Left=�6;   $��198,384,0,0q�6V   $	��Top=�6k   $	��171��6�   $��40��6�   ���	#FF93FFFD���	#FF92305C$��Adobe Myungjo Std M)�6�   $��19(�6   �� 5   
   -   5        $ changepassbtn��5      $��Change Password��6(   $
��Left=�6B   $��461,384,0,0q�6]   $	��Top=�6r   $	��183��6�   $��40��6�   ���	#FF93FFFD���	#FF92305C$��Adobe Myungjo Std M)�6�   $��19(�6
  �� 5   
   -   5        $ Addgood��5      $	��Add��6"   $
��Left=�60   $��505,140,0,0q�6K   $	��Top=�6`   $	��118��6x   $��40��6�   ���	#FF93FFFD���	#FF92305C$��Adobe Myungjo Std M)�6�   $��19(�6�    J� RenderTransformOrigin$ 
0.214,1.24&�6  �� 5   
   -	   5        $ 
removegood��5      $��Remove��6%   $
��Left=�6}   $��505,212,0,0q�6�   $	��Top=�6�   $	��118��6�   $��40��6�   ���	#FF93FFFD���	#FF92305C$��Adobe Myungjo Std M)�6#  $��19(�6D  {�66   ��  �� ElementName$ 
ManageList�� �� Path$ SelectedItems.Count�6D  �� 5   
   -
   5         ��Name$ 
ManageList��5      $
��Left=�6'   $	��Top=�6B   $	��208��6Z   $��
30,140,0,0q�6g   $	��431��6{    �� View 5       �� 5"      .P�5$      �� $
��Name��6%    �� Width$	 100��63    �� DisplayMemberBinding 6?   �� *Name+�� 5%      $��Price��6%   $ 75��64    6?   �� *Price+�� 5&      $��ID��6%   $ 75��61    6<   �� *ID+�� 5'      $��Pro 1��6%   $ 75��64    6?   �� *Pro1+�� 5(      $��Pro 2��6%   $ 75��64    6?   �� *Pro2+5*      5,      �� 5-   
   $
��ID :��6   $
��Left=�6   $��	30,69,0,0q�6:   $	��Top=�6M   $��30(�6e   $��Adobe Myungjo Std M)�6s   51      52      