#!/usr/bin/perl
#---------------------#
#  by lufer
#  argv.pl  
#---------------------#

$numArgs = $#ARGV + 1;
die if ($#ARGV==0);
print "Fixe: inseriu $numArgs argumentos\n";

#print @ARGV;

foreach $argnum (0 .. $#ARGV) {

   print "$ARGV[$argnum]\n";

}
