   M S B A M L   `   `   `  ����I  EOnlineStoreWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:OnlineStoreWPFOnlineStoreWPF  5   	        OnlineStoreWPF.PaymentPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:OnlineStoreWPF     5   	     � Title$  PaymentPage��5   	   $	��700��6   $	��530��6*    � Icon$ img/logo.jpg��66    � WindowStartupLocation$ CenterScreen=�6J    � AllowsTransparency .  � WindowStyle$
 None=�6�   ��5	      �� 5
   
    �� ImageSource$ img/BG5.png��6   .��5      � .+�5   
   �� -   5        $
��Back��5      $
��Left=�6    $��
36,602,0,0q�6;   $	��Top=�6O   $	��103��6g   $��67��6�   $��35(�6�   $��Adobe Myungjo Std M)�6�   ���	#FF7F1717���	#FFD4C03E���	#FF5C22226�   �� 5   
   -   5        $	��Buy��5      $
��Left=�6   $��385,602,0,0q�6:   $	��Top=�6O   $	��102��6g   $��67��6s   $��Adobe Myungjo Std M)�6   ���	#FF7F1717���	#FFD4C03E���	#FF5C2222$��35(�6�   �� 5   
   -   5         ��Name$ 	chancebtn��5      $��Chance��6$   $
��Left=�65   $��205,602,0,0q�6P   $	��Top=�6e   $	��124��6}   $��67��6�   $��Adobe Myungjo Std M)�6�   ���	#FF7F1717���	#FFD4C03E���	#FF5C2222$��30(�6  �� 5   
   -   5         ��Name$ 	FinalList��5      $
��Left=�6&   $	��415��6A   $��	36,35,0,0q�6N   $	��Top=�6a   $	��451��6y    �� View 5      �� 5      .P�5      �� $
��Name��6%   	 �� Width$		 170��63   
 �� DisplayMemberBinding
 6?   �� *Name+�� 5      $��Price��6%   $		 150��64   
 6@   �� *Price+�� 5      $��ID��6%   $		 100��61   
 6=   �� *ID+5      5      �� 5   
   -   5         ��Name$ Offbox��5      $
��Left=�6"   $��41��6=   {�.  $��150,465,0,0q�6[    �� TextWrapping$
 Wrap=�6p   $	��0 %��6�   $	��Top=�6�   $��72��6�   $��30(�6�   �� 5    
   -   5        $ totalpay��5       $
��Left=�6$   $��41��6?   {�.  $��353,471,0,0q�6]   $
 Wrap=�6r   $��100 $��6�   $	��Top=�6�   $	��134��6�   $��30(�6�   �� 5!   
   -   5        $ finalpay��5!      $
��Left=�6$   $��41��6?   {�.  $��353,534,0,0q�6]   $
 Wrap=�6r   $	��0 $��6�   $	��Top=�6�   $	��134��6�   $��30(�6�   �� 5"   
   $
��Left=�6   $��
36,465,0,0q�6/   $
��Wrap=�6C   $��OFF :��6W   $	��Top=�6d   ���	#FFCE9122$��41��6�   $��86��6�   $��24(�6�   $��Adobe Myungjo Std M)�6�   �� 5#   
   $
��Left=�6   $��266,465,0,0q�6/   $
��Wrap=�6D   $��Total :��6X   $	��Top=�6g   ���	#FFCE9122$��41��6�   $��86��6�   $��24(�6�   $��Adobe Myungjo Std M)�6�   �� 5$   
   $
��Left=�6   $��271,531,0,0q�6/   $
��Wrap=�6D   $��Final :��6X   $	��Top=�6g   ���	#FFCE9122$��44��6�   $��92��6�   $��24(�6�   $��Adobe Myungjo Std M)�6�   �� 5&   
   -   5        $ taxpay��5&      $
��Left=�6"   $��41��6=   {�.  $��150,531,0,0q�6[   $
 Wrap=�6p   $	��0 $��6�   $	��Top=�6�   $��95��6�   $��30(�6�   �� 5'   
   $
��Left=�6   $��
36,528,0,0q�6/   $
��Wrap=�6C   $��
With Tax :��6W   $	��Top=�6i   ���	#FFCE9122$��44��6�   $	��151��6�   $��20(�6�   $��Adobe Myungjo Std M)�6�   5*      5+      