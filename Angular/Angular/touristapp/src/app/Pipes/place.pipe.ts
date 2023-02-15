import { Pipe, PipeTransform } from '@angular/core';
import { Place } from '../Models/place';

@Pipe({
  name: 'place'
})
export class PlacePipe implements PipeTransform {

  transform(places: Place[], args: string): Place[] {
    debugger;
    if (args == "")
      return places;
    else
      return places.filter((p: Place) => p.Name.toLowerCase().includes(args.toLowerCase()));
  }
}
