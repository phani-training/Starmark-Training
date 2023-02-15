import { Component } from '@angular/core';
import { PlaceService } from '../../Services/place.service';

@Component({
  selector: 'app-add-new',
  templateUrl: './add-new.component.html',
  styleUrls: ['./add-new.component.css']
})
export class AddNewComponent {
  Name : string = "";
  PinCode: number = 0;
  State: string = "";
  Significance: string = "";
  Description:string = "";
  ImageFiles : any[] = [];
  ImagePath : string = "";
  constructor(private service : PlaceService) {
      
  }

  onUploadFile(files: any){
    let fileToUpload = <File>files[0];
    const formData = new FormData();
    formData.append("file", fileToUpload, fileToUpload.name);
    this.ImagePath = fileToUpload.name;
  }
  onSelectFile(event : any) {
    debugger;
    if (event.target.files && event.target.files.length) {
      this.onUploadFile(event.target.files);
      var reader = new FileReader();
      reader.readAsDataURL(event.target.files[0]);
      reader.onload = (_ev) => { 
        this.ImagePath = reader.result as string; 
        this.onAddImage();
      }
    }
    else {
      alert("No file is selected");
    }
  }
  onAddImage(){
    this.ImageFiles.push({ "ImageSource": this.ImagePath})
  }
  onAddNewPlace(){
    debugger;
    let place = {} as any;
    place.Name = this.Name;
    place.PinCode = this.PinCode;
    place.State = this.State;
    place.Significance = this.Significance;
    place.Description = this.Description;
    place.ImageFiles = this.ImageFiles;
    this.service.addNewPlace(place).subscribe((data)=>{
      alert("Place is inserted to the Storage")
    });
  }
}
