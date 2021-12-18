#!/usr/bin/perl

while (<*.txt>){
	print;
	$aux = lc $_;
	rename ($_,$aux) || warn $!;
}
print "done.\n";
