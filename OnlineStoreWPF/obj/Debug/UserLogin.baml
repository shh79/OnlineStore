   M S B A M L   `   `   `  ����I  EOnlineStoreWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:OnlineStoreWPFOnlineStoreWPF  5   	       OnlineStoreWPF.UserLogin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:OnlineStoreWPF     5   	     � Title$  	UserLogin��5   	   $	��260��6   $	��420��6(    � AllowsTransparency .  � WindowStyle$
 None=�6N    � WindowStartupLocation$ CenterScreen=�6a    � Icon$ img/AdminLogIcon.jpg��6�   .��5	      � ��5
   
   �� 5       �� ImageSource$ img/UserLog.jpg��6   .+�5   
   �� -   5         ��Name$ 
Log_button��5      $��Login��6%   {�. $
��Left=�6F   $	��Top=�6a   $��90��6y   $��133,180,0,0q�6�   ���	#FF73AA8A$��30��6�   �� 5   
   -   5        $
��Back��5      $
��Left=�6    $	��Top=�6;   $��90��6S   $��
21,180,0,0q�6^   ���	#FFE5AD8C$��30��6�   �� 5   
   -   5         ��Name$ UserNamebox��5      $
��Left=�6'   $��30��6B    �� TextWrapping$
 Wrap=�6N   $��	User Name��6b   $	��Top=�6s   $	��202��6�   $��	21,73,0,0q�6�   $��16(�6�   6�   �� 5   
   -   5        $ PassBox��5      $
��Left=�6#   $��30��6>   $
 Wrap=�6J   $�� ��6^   $	��Top=�6f   $	��202��6~   $��
21,123,0,0q�6�   $��16(�6�   6�   �� 5   
   -   5        	 ��Name$	 StuCH��5      $��Student��6"   $
��Left=�64   $	��Top=�6O   $��
306,56,0,0q�6g   
 J� RenderTransformOrigin$
 0.5,0.5&�6{   $��5(�6�   ���	#FFE82626$��Italic$�6�   $��Adobe Song Std L)�6�   $
��Bold"�6�   ��5      �� 5      $ img/Student.png��6   z�5      V� 5      .~�5      ��  �� ScaleX$ 5Q�6%    �� ScaleY$ 5Q�60   �� 5      �� 5      T� 5      5      5      �� 5    
   -   5        $
	 TeCH��5       $��Teacher��6!   $
��Left=�63   $	��Top=�6N   $��307,125,0,0q�6f   $
 0.5,0.5&�6{   $��5(�6�   ���	#FFE82626$��Italic$�6�   $��Adobe Song Std L)�6�   $
��Bold"�6�   ��5!      �� 5"      $ img/Teacher.png��6   z�5$      V� 5%      .~�5&      �� $ 5Q�6%   $ 5Q�60   �� 5'      �� 5(      T� 5)      5*      5,      �� 5.   
   -   5        $
	 CUCH��5.      $��Customer��6!   $
��Left=�64   $	��Top=�6O   $��306,194,0,0q�6g   $
 0.5,0.5&�6|   $��4(�6�   ���	#FFE82626$��Italic$�6�   $��Adobe Song Std L)�6�   $
��Bold"�6�   ��5/      �� 50      $ img/Customer.png��6   z�52      V� 53      .~�54      �� $ 5Q�6%   $ 5Q�60   �� 55      �� 56      T� 57      58      5:      �� 5;   
   $
��Left=�6   $
��Wrap=�6/   $(��"Please choose your account first .��6C   $	��Top=�6m   $��	21,30,0,0q�6�   ���	#FFCCD418$��14(�6�   $��Adobe Kaiti Std R)�6�   $
��Bold"�6�   ���	#FF0E262D6�   5>      5?      