   M S B A M L   `   `   `  ����H  DCodeGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:CodeGeneratorCodeGenerator  5   	       CodeGenerator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:CodeGenerator     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   $��
Constantia)�65   $��16(�6M   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��151* �6   �� 5      $
��151* �6   �� 5      $
��150* �6   �� 5      $	��65* �6    � RowDefinitions 5   
   �� 5      $	��48* �6   �� 5      $	��80* �6   �� 5      $	��64* �6   �� 5      $	��64* �6   �� 5      $	��63* �6   .+�5   
   �� -   5         ��Name$ btnConnection��5      $��New Connection��6(   $��0��6A   $��10,10q�6m   �� 5   
   -   5         ��Name$ txtConnectionString��5      $��1��61   $
��Wrap=�6B   $�� ��6V   $��10,15q�6`   $��3��6o   �� 5   
   $��1��6   $��Database��6   $��10,25q�60   $��Center=�6?   $��30��6Z   6h   �� 5   
   -   5        $��cbPreviousDb��5      $��1��6'   $��1��64   $��3��6D   $��10,25q�6X   5      �� 5   
   -   5        $ btnDatabaseClasses��5      $��Database��6-   $��2��6@   $��10q�6M   6Y   �� 5   
   -   5        $ btnViewClasses��5      $
��View��6)   $��2��68   $��1��6E   $��10q�6U   6a   �� 5   
   -   5        $ btnAngularClasses��5      $��Angular��6,   $��2��6>   $��2��6K   $��10q�6[   6g   �� 5   
   -   5         ��Name$ chkMultipleFiles��5      $��Multiple Files��6.   $
��Left=�6G   $��	10,19,0,0q�6b   $��3��6u   $	��Top=�6�   5!      5"      