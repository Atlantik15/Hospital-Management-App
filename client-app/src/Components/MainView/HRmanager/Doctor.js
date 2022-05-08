import React, {useEffect,useState} from 'react';
import DoctorForm from './DoctorForm';
import PageHeader from '../mainComponents/Components/PageHeader';
import PeopleOutLineTwoToneIcon from '@material-ui/icons/PeopleOutlineTwoTone';
import { Paper,makeStyles,TableBody,TableRow,TableCell,TableHead,Toolbar,withStyles,InputAdornment} from '@material-ui/core';
import useTable from "../mainComponents/Components/useTable";
import Controls from "../mainComponents/controls/Controls";
import {Input} from "../Dashboard/controls";
import {Search} from '@material-ui/icons';
import AddIcon from '@material-ui/icons/Add';
import Popup from '../mainComponents/Components/Popup';
import EditOutlinedIcon from "@material-ui/icons/EditOutlined";
import CloseIcon from '@material-ui/icons/Close';
import * as actions from "./Actions/hrDoctor";
import {connect} from "react-redux";
import {ToastProvider,useToasts} from "react-toast-notifications";

const styles=makeStyles(theme=>({
    pageContent:{
        margin:theme.spacing(5),
        padding:theme.spacing(3)
    },
    searchInput:{
        width:'75%'
    },
    newButton:{
        position:'absolute',
        right:'10px'
    }
}))

const headCells=[
    {id:'firstName',label:'First Name'},
    {id:'lastName',label:'Last Name'},
    {id: 'department',label:'Department'},
    {id:'specialist',label:'Specialist'},
    {id:'actions',label:'Actions',disableSorting:true}
]

const Doctor = ({classes , ...props}) => {
    
    const [currentId,setCurrentId]=useState(0)
    const [openPopup,setOpenPopup]=useState(false);


    useEffect(()=>{
        props.fetchAllDoctors()
    },[])
    
    const{addToast}=useToasts()

    const {
        TblContainer,
        TblPagination,
    } = useTable(headCells);


    const onDelete=id=>{
        if(window.confirm('Are you sure to delete this record?'))
        props.deleteDoctor(id,()=>addToast("Deleted successfully",{appreance:'info'}))
    }

    return(
        <>
            <PageHeader title="New Doctor" subTitle="Manage Doctors"  icon={<PeopleOutLineTwoToneIcon fontSize="large"/>} />

            <Paper className={classes.pageContent}>
            <Toolbar>
                    <Input
                        label="Search Doctors"
                        className={classes.searchInput}
                        InputProps={{
                            startAdornment: (<InputAdornment position="start">
                                <Search />
                            </InputAdornment>)
                        }}
                        //onChange={handleSearch}
                    />
                    <Controls.Button
                        text="Add New"
                        variant="outlined"
                        startIcon={<AddIcon />}
                        className={classes.newButton}
                        onClick={() => { setOpenPopup(true);}}
                    />
                </Toolbar>
                <TblContainer>
                    <TableHead>
                        <TableCell>First name</TableCell>
                        <TableCell>Last Name</TableCell>
                        <TableCell>Department</TableCell>
                        <TableCell>Specialist</TableCell>
                        <TableCell>Actions</TableCell>
                    </TableHead>
                        <TableBody>
                                {
                                    props.doctorList.map((record,index)=>{
                                        return(
                                            <TableRow key={index} hover>
                                                <TableCell>{record.firstName}</TableCell>
                                                <TableCell>{record.lastName}</TableCell>
                                                <TableCell>{record.department}</TableCell>
                                                <TableCell>{record.specialist}</TableCell>
                                            <TableCell>
                                                  <Controls.ActionButton color="primary">
                                                      <EditOutlinedIcon fontSize="small" onClick={()=>{setOpenPopup(true);setCurrentId(record.id)}}/>
                                                  </Controls.ActionButton>
                                                  <Controls.ActionButton color="secondary">
                                                      <CloseIcon fontSize="small" onClick={()=> onDelete(record.id)}/>
                                                  </Controls.ActionButton>
                                            </TableCell>
                                            </TableRow>
                                        )
                                    })
                                }   
                        </TableBody>
                </TblContainer>
                <TblPagination />
            </Paper>
            
            <Popup title="Doctor Form" openPopup={openPopup} setOpenPopup={setOpenPopup}>
                <DoctorForm {...({currentId,setCurrentId})}/>
            </Popup>
        </>
    )
}

const mapStateToProps=state=>({
    doctorList: state.dReminders.list
});

const mapActionToProps={
    fetchAllDoctors:actions.fetchAll,
    deleteDoctor:actions.Delete
}

export default connect(mapStateToProps,mapActionToProps)(withStyles(styles)(Doctor));