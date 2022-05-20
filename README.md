# MeetingTask
List methods with arrow functions (delegate)

<pre>

Meeting class:
  -FromDate: Meetingin baslama tarixini bildirir
  -ToDate: Meetingin bitme tarixini bldirir
  -Name: Meetigin adini bildirir
 
MeetingSchedule class:
  - Meetings: Meeting listi
  - SetMeeting(name,from,to):
        - gonderilmis deyerlere esasen meeting yaratmaga calisir.
        - Eger Gonderilmis tarix intervalinda meeting varsa geriye Exception qaytarir
        - her sey okaydirse meeting obyekti yaradib meeting listine add edir.

<b>FindMeetingsCount()</b> - bu metod  parametr olaraq datetime qebul edir ve hemin date-den sonra baslayan meetinglerin sayini qaytarir

<b>FindMeetings()</b> - bu metod parametr olaraq predicate qebul edir ve hemin predicate sertini odeyen meetinglerden ibaret list qaytarir

<b>ExistMeetingsByName()</b> - bu metod parametr olaraq string qebul edir ve eger meetings listinde hansisa meetingin name deyerinde parametr olaraq gonderilen string deyer varsa  true, yoxdursa false qaytarir

<b>ExistMeetings()</b> - bu metod parametr oaraq predicate qebul edir ve eger meetings listinde hemin predicate sertini odeye meeting varsa true, yoxdursa false qaytarir

</pre>
