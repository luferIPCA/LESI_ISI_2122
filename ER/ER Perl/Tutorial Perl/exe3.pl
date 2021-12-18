#!d:\perl\bin\perl -w
# --------------------------------------------------------------------
# Perl by example
# exemplos de Perl (3)
# by lufer
# --------------------------------------------------------------------

print "ola\n";
print 'ole\n';
print `dir *.pl`;
print q/olo/;
print qx/dir *.pl/;


#exit();

#-----------------------------------
@aux=qw/jan fev mar abr mai jun/;
print "Total: ".@aux."\n";
print "Elements: ";print @aux;print "\n";
print $#aux."\n";
print $aux[2] . "\n";
print $aux[-1]."\n";

#-----------------------------------
($a,$b,$c)=(a..z)[2,7,12];
print "\$a=$a \$b=$b \$c=$c\n";

#-----------------------------------
