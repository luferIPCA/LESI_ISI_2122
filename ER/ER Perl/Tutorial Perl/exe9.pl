#!d:\perl\bin\perl -w
# --------------------------------------------------------------------
# Perl by example
# exemplos de Perl (9)
# by lufer
# Expressões Regulares
# --------------------------------------------------------------------


#$target = "#";
#open(INPUT, "<exe8.pl");
#while (<INPUT>) {
#     if (/$target/) {
#         print "Found $target on line $.\n";
#     }
#}
#close(INPUT);

#-----------------------------------
#Translation
$_="aaabbbcccddd";
$y=tr/ac/zy/;
$r =~ tr/ac/zy/;
print "Original:$_\n";
print "Letras Traduzidas: $y\n";
print "Traduzido: $r\n";



#Substitution and Search
$scalar       = "The root has many leaves";
$match        = $scalar =~ m/root/;
$substitution = $scalar =~ s/root/tree/;
$translate    = $scalar =~ tr/h/H/;

print("\$match        = $match\n");
print("\$substitution = $substitution\n");
print("\$translate    = $translate\n");
print("\$scalar       = $scalar\n");


$scalar = "A arvore tem varias folhas";
print("String não tem a palavra arvore.\n") if $scalar !~ m/arvore/;#negar =~
$scalar =~ s/arvore/raiz/;
$scalar =~ tr/h/H/;
print("\$scalar = $scalar\n");

$_ = "O Benfica é o Maior";
s/([A-Z])/:$1:/g;
print "$_\n";

