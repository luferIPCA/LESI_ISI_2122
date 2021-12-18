#by lufer
#EST-IPCA

#!/usr/local/bin/perl -w

#--------------------------------------------------------

#Verifica��o de Datas
$t="2001-13-10";
print ("$t � v�lida?".isvaliddate($t));


#-----------------------------------
sub isvaliddate {
  my $input = shift;
  if ($input =~ m!^((?:19|20)\d\d)[- /.](0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])$!) {
    # $1=ano; $2=m�s; $3=dia
    if ($3 == 31 and ($2 == 4 or $2 == 6 or $2 == 9 or $2 == 11)) {
      return 0; 
    } elsif ($3 >= 30 and $2 == 2) {
      return 0; # M�s de Fevereiro
    } elsif ($2 == 2 and $3 == 29 and not ($1 % 4 == 0 and ($1 % 100 != 0 or $1 % 400 == 0))) {
      return 0; # Fevereiro no ano n�o bissexto n�o tem 29 dias
    } else {
      return 1; # OK
    }
  } else {
    return 0; # Data inv�lida
  }
}

