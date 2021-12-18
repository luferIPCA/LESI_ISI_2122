#!/usr/bin/perl
#---------------------#
#  PROGRAM:  argv.pl  #
#---------------------#

$numArgs = $#ARGV + 1;
print "Fixe: inseriu $numArgs argumentos\n";

foreach $argnum (0 .. $#ARGV) {

   print "$ARGV[$argnum]\n";

}
