import {SortEnum} from "../../enums/sort.enum";

export class ShopParams {
  brandId: number = 0;
  typeId: number = 0;
  sort: any = SortEnum.AlphaBetical;
  pageNumber = 1;
  pageSize = 6;
  search: string;
}
