import ProductOrderView from "../views/ProductOrderView";

import styles from '../gen_page.module.css';
import {Breadcrumb, InputNumber} from "antd";

import PATH from "../../PATH";
import LOGIC from "../../LOGIC";
import {Delete} from "@material-ui/icons";


interface Props {
    ProductOrderView: ProductOrderView,
    isInteractive: boolean,
}

export default function ProductOrderCard({ProductOrderView, isInteractive}: Props) {
    
    return(
        <div className={`${styles.boxey} d-flex`} style={{
            height: '160px',
            padding: '8px',
            marginBottom: '24px',
        }}>
            <div className={styles.boxey} style={{
                width: '144px',
                height: '144px',
                border: 'none',
                backgroundImage: `url(${ProductOrderView?.ImagePath})`,
                backgroundSize: 'contain',
            }}/>
            <div style={{
                borderLeft: '1px solid #000',
                marginLeft: '8px',
                marginRight: '8px',
                marginTop: '-8px',
                marginBottom: '-8px',
            }}/>
            <div className='d-flex flex-grow-1 justify-content-between'>
                <div className='d-flex flex-column justify-content-between'>
                    <div>
                        <Breadcrumb>
                            {
                                ProductOrderView?.CategoryPath?.map(
                                    cat => <Breadcrumb.Item><a href={PATH.ToCategory(cat.Id)} target="_self">{cat.Name}</a></Breadcrumb.Item>
                                )
                            }
                        </Breadcrumb>
                        <h3>{ProductOrderView.Name}</h3>
                        <p style={{fontSize: '14px'}}>{LOGIC.GetShortDescription(ProductOrderView.Attributes)}</p>
                    </div>
                    <h3 style={{fontWeight: 'lighter'}}>{`$${ProductOrderView.Price.toFixed(2)}${ProductOrderView.Count > 1 ? ` × ${ProductOrderView.Count} = $${(ProductOrderView.Price*ProductOrderView.Count).toFixed(2)}` : ``} per day`}</h3>
                </div>
                { isInteractive ?
                    <div className='d-flex align-items-center'>
                        <div style={{
                            paddingRight: '24px'
                        }}>
                            <Delete style={{
                                fontSize: '32px',
                                color: '#ff6655',
                                marginRight: '24px',
                            }}/>
                            <InputNumber defaultValue={ProductOrderView.Count} style={{
                                height: '32px',
                                width: '60px',
                            }}/>
                            
                        </div>
                    </div>
                        : <></> }
            </div>
        </div>
    );
}
