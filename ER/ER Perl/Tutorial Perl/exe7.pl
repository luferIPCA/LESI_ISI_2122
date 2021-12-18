#!d:\perl\bin\perl -w
# --------------------------------------------------------------------
# Perl by example
# exemplos de Perl (7)
# by lufer
# --------------------------------------------------------------------


#-----------------------------------
# Valores por referências
#$x = \$y 	-> ${$x}
#$x = \@y	-> @{$y}
#$x = \%y	-> %{$y}

firstSub( \(1..5), \("A".."E") );                         # 



sub firstSub {

    my($ref_firstArray, $ref_secondArray) = @_ ;          #



    print("The first array is  @{$ref_firstArray}.\n");   #

    print("The second array is @{$ref_secondArray}.\n");  #

}

