import { Component, OnInit } from '@angular/core';
import { DataService } from '../../Services/data.service';
import { DataModel } from '../../Models/data-model';
@Component({
  selector: 'app-data',
  templateUrl: './data.component.html',
  styleUrls: ['./data.component.css']
})
export class DataComponent implements OnInit {
  data : DataModel[] = [];
  constructor(private service : DataService) {
    
  }
      ngOnInit(): void {
        this.service.getAllData().subscribe((data : DataModel[])=>{
          this.data = data;
        })
      }
}
