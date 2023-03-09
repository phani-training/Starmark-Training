import { Pipe, PipeTransform } from '@angular/core';
@Pipe({
  name: 'days'
})
export class DaysPipe implements PipeTransform {

  transform(input: string, ...args: unknown[]): string {
    const old = new Date(input);
    const current : Date = new Date();
    const duration = current.getTime() - old.getTime() ;
    const Difference_In_Days = duration / (1000 * 3600 * 24);
    return Math.floor(Difference_In_Days) + " Days"; 
  }

}
